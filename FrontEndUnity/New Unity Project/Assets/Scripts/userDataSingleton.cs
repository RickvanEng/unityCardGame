using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using LitJson;
using System.Text;
using System;

public class userDataSingleton : MonoBehaviour {

	static userDataSingleton instance = null;

	public jsonToClass jsonToClass;

	private static string user;

	private static List<Deck> playerDecks;

	public static Deck selectedDeck;

	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
			print ("singleton copy destructed");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	public static void setUser(string loggedUser) {
		user = loggedUser;
		getUserData(user);
	}

	public static void getUser() {
		
	}

	private static void getUserData(string user) {
        string CreateAccountURL = "http://localhost:2000/getUserDecks";
        string json = "{\"username\": \"" + userDataSingleton.user + "\"}";
        byte[] body = Encoding.UTF8.GetBytes(json);


        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/json");

        WWW www = new WWW(CreateAccountURL, body, headers);
        
        StartCoroutine(WaitForRequest(www));
    }

    private static IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
			List<Deck> deckList =  new List<Deck>();
            JsonData jsonPlayerDecks = JsonMapper.ToObject(www.text);

            foreach (JsonData jsonDeck in jsonPlayerDecks["value"])
            {
                Deck deck = jsonToClass.setJsonToDeck(jsonDeck);
                deckList.Add(deck);
            }

            //set data in user singleton
            userDataSingleton.setPlayerDecks(deckList);

            print(loadUIScript);

            //call mehthod to load decks in UI
            loadUIScript.GetComponent<loadUIElements>().load();
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

	public static void setPlayerDecks(List<Deck> decks) {
		playerDecks = decks;
	}

	public static List<Deck> getPlayerDecks() {
		return playerDecks;
	}
}
