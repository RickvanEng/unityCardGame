using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race {

	private string _id;
	private string race;
	private string displayRace;
	private string imgPath;

	//private array met race abilties

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setRace(string race) {
		this.race = race;
	}

	public string getRace() {
		return race;
	}

	public void setDisplayRace(string displayRace) {
		this.displayRace = displayRace;
	}

	public string getDisplayRace() {
		return displayRace;
	}

	public void setImgPath(string imgPath) {
		this.imgPath = imgPath;
	}

	public string getImgPath() {
		return imgPath;
	}
	
}
