using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System.Collections.Generic;
using System;

public class loadUIElements : MonoBehaviour {

	public GameObject prefab;
	void Start () {
	}
	
	//for each Deck in userDataSingleton we are gonna load a deck.
	public void load() {
		for (int i = 0; i < userDataSingleton.getPlayerDecks().Count; i++) {
			GameObject createdDeck = Instantiate(prefab, transform.position, Quaternion.identity);
			createdDeck.GetComponent<playerDecksScript>().deck = userDataSingleton.getPlayerDecks()[i];
			createdDeck.GetComponent<playerDecksScript>().title.text = createdDeck.GetComponent<playerDecksScript>().deck.getDeckName();
		}
		


		//prefab.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
	}
}
