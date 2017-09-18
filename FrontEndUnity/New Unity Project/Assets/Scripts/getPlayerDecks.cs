using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System.Collections.Generic;
using System;

public class getPlayerDecks : MonoBehaviour
{   

    //script references
    public GameObject loadUIScript;

    public jsonToClass jsonToClass;

    public List<Deck> deckList =  new List<Deck>();

    

    void awake() {
        //loadUIScript = GameObject.Find("loadUIElementsObject");
    }

    // Use this for initialization
    void Start() {
        
    }
    

    

}
