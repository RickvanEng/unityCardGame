using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Class {

	private string type;

	private int level;

	public void setType(string type) {
		this.type = type;
	}

	public string getType() {
		return type;
	}

	public void setLevel(string level) {
		this.level = Convert.ToInt32(level);
	}

	public int getLevel() {
		return level;
	}


}
