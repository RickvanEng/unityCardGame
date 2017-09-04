using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class CardInDeckScript : MonoBehaviour {

	public Card cardData;

	public Text title;

	public Text amount;

	//parent object
	public GameObject holder;

	public GameObject userData;



	public void initialize(Card cardObject) {
		this.cardData = cardObject;

		this.holder = GameObject.FindGameObjectWithTag("DeckField");
		this.transform.SetParent(holder.transform);

		this.title.text = this.cardData.getName();

		int intAmnount = 0;
		for (int i = 0; i < userDataSingleton.selectedDeck.getCards().Count; i++) {
			if (title.text == userDataSingleton.selectedDeck.getCards()[i].getName()) {
				intAmnount++;
			}
		}

		amount.text = intAmnount.ToString();

	}
}
