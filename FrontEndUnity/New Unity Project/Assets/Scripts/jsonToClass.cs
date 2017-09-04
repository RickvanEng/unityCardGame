using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System.Collections.Generic;
using System;

public class jsonToClass : MonoBehaviour {

	public Deck setJsonToDeck(JsonData json)
    {

        Deck deck = new Deck();

        //id            string
        //deckOwner     string
        //deckName      string
        //race          Race
        //elements      List<Element>
        //cards         List<Card>

        deck.setID(json["_id"].ToString());
        deck.setDeckOwner(json["deckOwner"].ToString());
        deck.setDeckName(json["deckName"].ToString());
        deck.setRace(setJsonToRace(json["race"]));
        deck.setElements(setJsonToElements(json["elements"]));
        deck.setCards(setJsonToCard(json["cards"]));

		return deck;
        
    }

    private Type setJsonToType(JsonData json)
    {
        Type type = new Type();

        type.setID(json["_id"].ToString());
        type.setType(json["type"].ToString());

        return type;
    }

    private Role setJsonToRole(JsonData json)
    {
        Role role = new Role();
        role.setID(json["_id"].ToString());
        role.setRole(json["role"].ToString());

        return role;
    }

    private Race setJsonToRace(JsonData json)
    {
        Race raceClass = new Race();

        raceClass.setID(json["_id"].ToString());
        raceClass.setRace(json["race"].ToString());
        raceClass.setDisplayRace(json["displayRace"].ToString());
        raceClass.setImgPath(json["imgPath"].ToString());

        return raceClass;
    }

    private List<Element> setJsonToElements(JsonData json)
    {

        List<Element> elementList = new List<Element>();

        foreach (JsonData jsonElement in json)
        {
            Element element = new Element();

            element.setID(jsonElement["_id"].ToString());
            element.setElement(jsonElement["element"].ToString());
            element.setElementInfo(jsonElement["elementInfo"].ToString());

            elementList.Add(element);
        }

        return elementList;
    }

    private Element setJsonToElement(JsonData json)
    {

        Element element = new Element();

        element.setID(json["_id"].ToString());
        element.setElement(json["element"].ToString());
        element.setElementInfo(json["elementInfo"].ToString());

        return element;
    }

    private Class setJsonToClass(JsonData json)
    {

        Class classs = new Class();

        classs.setType(json["type"].ToString());
        classs.setLevel(json["level"].ToString());

        return classs;
    }

    public List<Card> setJsonToCard(JsonData json)
    {

        List<Card> cards = new List<Card>();

        foreach (JsonData jsonCard in json)
        {
            Card card = new Card();

            card.setID(jsonCard["_id"].ToString());
            card.setName(jsonCard["name"].ToString());
            //type en role is nog niet goed, krijgt objectId in plaats van object
            card.setType(setJsonToType(jsonCard["type"]));
            card.setRole(setJsonToRole(jsonCard["role"]));
            card.setRace(setJsonToRace(jsonCard["race"]));
            card.setElement(setJsonToElement(jsonCard["element"]));
            card.setImgPath(jsonCard["imgPath"].ToString());
            card.setCardClass(setJsonToClass(jsonCard["class"]));
            card.setManaCost(jsonCard["manaCost"].ToString());
            card.setManaGive(jsonCard["manaGive"].ToString());
            card.setPower(jsonCard["power"].ToString());
            card.setHealth(jsonCard["health"].ToString());
            card.setArmor(jsonCard["armor"].ToString());

            cards.Add(card);
        }

        return cards;
    }
}
