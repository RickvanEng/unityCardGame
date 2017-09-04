using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {

	private string _id;
	private string deckOwner;
	private string deckName;
	private Race race;

	private List<Element> elements;

	private List<Card> cards;


	//getters & setters

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setDeckOwner(string owner) {
		this.deckOwner = owner;
	}

	public string getDeckOwner() {
		return deckOwner;
	}

	public void setDeckName(string name) {
		this.deckName = name;
	}

	public string getDeckName() {
		return deckName;
	}

	public void setRace(Race race) {
		this.race = race;
	}

	public Race getRace() {
		return race;
	}

	public void setElements(List<Element> elements) {
		this.elements = elements;
	}

	public List<Element> getElements() {
		return elements;
	}

	public void setCards(List<Card> cards) {
		this.cards = cards;
	}

	public List<Card> getCards() {
		return cards;
	}

}
