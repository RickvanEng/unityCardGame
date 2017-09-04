using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditDeckLoadUI : MonoBehaviour
{

    //this script loads the cards in the canvas
    public GameObject cardsInDeckPrefab;
    public GameObject allCardsPrefab;


    public GameObject deckCardHolder;
    public GameObject allCardsHolder;

    

    // Use this for initialization
    void Start()
    {
        loadCardsInDeck();
        loadallCards();
    }

    private void loadCardsInDeck() {
        List<string> doubleCards = new List<string>();

        for (int i = 0; i < userDataSingleton.selectedDeck.getCards().Count; i++)
        {

            if (doubleCards.Count > 0)
            {

                bool addToUI = true;

                for (int y = 0; y < doubleCards.Count; y++)
                {
                    if (doubleCards[y] == userDataSingleton.selectedDeck.getCards()[i].getName())
                    {
                        addToUI = false;
                        break;
                    }
                }

                if (addToUI == true)
                {
                    print("hij komt in true");
                    GameObject card = Instantiate(cardsInDeckPrefab, transform.position, Quaternion.identity);
                    card.GetComponent<CardInDeckScript>().initialize(userDataSingleton.selectedDeck.getCards()[i]);

                    
                    doubleCards.Add(userDataSingleton.selectedDeck.getCards()[i].getName());

                    card.transform.SetParent(deckCardHolder.transform);
                }
            
            }
            else
            {
                doubleCards.Add(userDataSingleton.selectedDeck.getCards()[i].getName());
                GameObject card = Instantiate(cardsInDeckPrefab, transform.position, Quaternion.identity);
                card.GetComponent<CardInDeckScript>().initialize(userDataSingleton.selectedDeck.getCards()[i]);


            }
        }
    }

    private void loadallCards() {
        //loadCardScript word hier aangeroepen.
    }
}
