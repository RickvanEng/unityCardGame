using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System;

public class loadCardScript : MonoBehaviour{

	public List<Card> loadCardByName(string name) {
		List<Card> list = new List<Card>();


		return list;
	}

	public List<Card> loadCardByRace(Race race) {
		List<Card> list = new List<Card>();


		return list;
	}

	public List<Card> loadCardByElement(Element element) {
		List<Card> list = new List<Card>();


		return list;
	}

	public List<Card> loadCardByType(Type type) {
		List<Card> list = new List<Card>();


		return list;
	}

	public List<Card> loadCardByClass(Class classs) {
		List<Card> list = new List<Card>();


		return list;
	}

	// void restConnection()
    // {
    //     string CreateAccountURL = "http://localhost:2000/getUserDecks";
    //     string json = "{\"username\": \"" + userDataSingleton.loggedUser + "\"}";
    //     byte[] body = Encoding.UTF8.GetBytes(json);


    //     Dictionary<string, string> headers = new Dictionary<string, string>();
    //     headers.Add("Content-Type", "application/json");

    //     WWW www = new WWW(CreateAccountURL, body, headers);
		
    //     StartCoroutine(WaitForRequest(www));
    // }

    // private IEnumerator WaitForRequest(WWW www)
    // {
    //     yield return www;

    //     // check for errors
    //     if (www.error == null)
    //     {
    //         JsonData jsonPlayerDecks = JsonMapper.ToObject(www.text);

    //         foreach (JsonData jsonDeck in jsonPlayerDecks["value"])
    //         {
    //             Deck deck = jsonToClass.setJsonToDeck(jsonDeck);
    //             deckList.Add(deck);
    //         }

    //         //set data in user singleton
    //         userDataSingleton.setPlayerDecks(deckList);

    //         print(loadUIScript);

    //         //call mehthod to load decks in UI
    //         loadUIScript.GetComponent<loadUIElements>().load();
    //     }
    //     else
    //     {
    //         Debug.Log("WWW Error: " + www.error);
    //     }
    // }

}
