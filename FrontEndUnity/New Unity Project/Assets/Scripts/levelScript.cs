using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelScript : MonoBehaviour {

	public void loadLevel(string level) {
		Application.LoadLevel(level);
	}
}
