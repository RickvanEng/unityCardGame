using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role {

	private string _id;
	private string role;

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setRole(string role) {
		this.role = role;
	}

	public string getRole() {
		return role;
	}

}
