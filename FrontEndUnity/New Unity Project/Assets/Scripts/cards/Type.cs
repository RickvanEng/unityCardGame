using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type {

	private string _id;
	private string type;

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setType(string type) {
		this.type = type;
	}

	public string getType() {
		return type;
	}

}
