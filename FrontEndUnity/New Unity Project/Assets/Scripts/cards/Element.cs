using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element {

	private string _id;
	private string element;
	private string elementInfo;

	public void setID(string id) {
		this._id = id;
	}

	public string getID() {
		return _id;
	}

	public void setElement(string element) {
		this.element = element;
	}

	public string getElement() {
		return element;
	}

	public void setElementInfo(string info) {
		this.elementInfo = info;
	}

	public string getElementInfo() {
		return elementInfo;
	}
	
}
