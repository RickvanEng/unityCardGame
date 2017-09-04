using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class playerDecksScript : MonoBehaviour {

	private GameObject deckSpace;

	public Deck deck;

	public Text title;

	public GameObject levelScript;


	// Use this for initialization
	void Start () {
		levelScript = GameObject.FindGameObjectWithTag("levelScriptObject");
		deckSpace = GameObject.FindGameObjectWithTag("DeckField");
		
		this.transform.SetParent(deckSpace.transform);
	}

	public void selectDeck() {
		userDataSingleton.selectedDeck = deck;
		levelScript.GetComponent<levelScript>().loadLevel("editDeck");
	}
	
}
