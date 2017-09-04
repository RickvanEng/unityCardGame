using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class cardObjectScript : MonoBehaviour
{

    public Card cardData;
    public string _id;
    public string cardName;
    public Type type;
    public Role role;
    public Race race;
    public Element element;
    public string imgPath;
    public Class cardClass;
    public int manaCost;
    public int manaGive;
    public int power;
    public int health;
    public int armor;

    public void initialize(Card cardObject)
    {
        this.cardData = cardObject;

		this._id = cardObject.getID();
		this.cardName = cardObject.getName();
		this.type = cardObject.getType();
		this.role = cardObject.getRole();
		this.race = cardObject.getRace();
		this.element = cardObject.getElement();
		this.imgPath = cardObject.getImgPath();
		this.cardClass = cardObject.getCardClass();
		this.manaCost = cardObject.getManaCost();
		this.manaGive = cardObject.getmManaGive();
		this.power = cardObject.getPower();
		this.health = cardObject.getHealth();
		this.armor = cardObject.getArmor();

    }

    public void setParent(GameObject parent)
    {
        this.transform.SetParent(parent.transform);
    }


}
