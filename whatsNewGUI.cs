using UnityEngine;
using System.Collections;

public class whatsNewGUI : mainMenu {

	// Use this for initialization
//	void Start () {
//		guiText.text = "IMPROVED main menu\nTWEAKED block properties to make the game more challenging\n
//		ADDED better music\n FIXED the Space exploit, you CancelInvoke no
//	}
	
	// Update is called once per frame
	void OnGUI () {
		if (isDone == true) {
			if (GUI.Button(new Rect ((Screen.width/2)-50, (Screen.height/2)+150, 100, 50), "Back to Menu"))
				Application.LoadLevel ("mainMenu");
		}
	}
}
