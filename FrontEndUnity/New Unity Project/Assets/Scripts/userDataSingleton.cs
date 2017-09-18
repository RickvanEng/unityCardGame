using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using LitJson;
using System.Text;
using System;

public class userDataSingleton : MonoBehaviour {

	static userDataSingleton instance = null;

	public static jsonToClass jsonToClass;

	private static string user;

	private static List<Deck> playerDecks;

	public static Deck selectedDeck;

    private static IEnumerator routine;

    public static string test = "test";

	// Use this for initialization
	void Start () {
		if (instance == null) {
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
;	}

	public static void getUser() {
		
	}

	private static void getUserData(string user) {
        print("in getdata");
        string CreateAccountURL = "http://localhost:2000/getUserDecks";
        string json = "{\"username\": \"" + userDataSingleton.user + "\"}";
        byte[] body = Encoding.UTF8.GetBytes(json);


        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/json");

        WWW www = new WWW(CreateAccountURL, body, headers);
        
        routine = WaitForRequest(www);
        instance.StartCoroutine(routine);
    }

    private static IEnumerator WaitForRequest(WWW www)
    {
        print("in anders hizzle");
        yield return www;

        // check for errors
        if (www.error == null)
        {
            print("jha en nu");
			List<Deck> deckList =  new List<Deck>();
            JsonData jsonPlayerDecks = JsonMapper.ToObject(www.text);

            print(jsonPlayerDecks["value"]);

            foreach (JsonData jsonDeck in jsonPlayerDecks["value"])
            {
                Deck deck = jsonToClass.setJsonToDeck(jsonDeck);
                deckList.Add(deck);
            }

            //set data in user singleton
            userDataSingleton.setPlayerDecks(deckList);
            print(getPlayerDecks());


            //call mehthod to load decks in UI
            // loadUIScript.GetComponent<loadUIElements>().load();
        }
        else
        {

            print("WWW Error: " + www.error);
        }
    }

	public static void setPlayerDecks(List<Deck> decks) {
		playerDecks = decks;
	}

	public static List<Deck> getPlayerDecks() {
		return playerDecks;
	}
}
