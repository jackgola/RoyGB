using UnityEngine;
using System.Collections;

public class playerScore : Falling {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.fontSize = 58;
		guiText.text = "" + score;
	}
}
