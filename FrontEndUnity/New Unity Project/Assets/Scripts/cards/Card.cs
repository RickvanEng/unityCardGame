using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.UI;


public class Card {

	private string _id;
	private string name;
	private Type type;
	private Role role;
	private Race race;
	private Element element;
	private string imgPath;
	private Class cardClass;
	private int manaCost;
	private int manaGive;
	private int power;
	private int health;
	private int armor;

	//moet nog geimplementeerd worden
	//private CardAbility abilities = [];

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setName(string name) {
		this.name = name;
	}

	public string getName() {
		return name;
	}

	public void setType(Type type) {
		this.type = type;
	}

	public Type getType() {
		return type;
	}

	public void setRole(Role role) {
		this.role = role;
	}

	public Role getRole() {
		return role;
	}

	public void setRace(Race race) {
		this.race = race;
	}

	public Race getRace() {
		return race;
	}

	public void setElement(Element element) {
		this.element = element;
	}

	public Element getElement() {
		return element;
	}

	public void setImgPath(string path) {
		this.imgPath = path;
	}

	public string getImgPath() {
		return imgPath;
	}

	public void setCardClass(Class cardClass) {
		this.cardClass = cardClass;
	}

	public Class getCardClass() {
		return cardClass;
	}

	public void setManaCost(string manaCost) {
		this.manaCost = Convert.ToInt32(manaCost);
	}

	public int getManaCost() {
		return manaCost;
	}

	public void setManaGive(string manaGive) {
		this.manaGive = Convert.ToInt32(manaGive);
	}

	public int getmManaGive() {
		return manaGive;
	}

	public void setPower(string power) {
		this.power = Convert.ToInt32(power);
	}

	public int getPower() {
		return power;
	}

	public void setHealth(string health) {
		this.health = Convert.ToInt32(health);
	}

	public int getHealth() {
		return health;
	}

	public void setArmor(string armor) {
		this.armor = Convert.ToInt32(armor);
	}

	public int getArmor() {
		return armor;
	}

}
