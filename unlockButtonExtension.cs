using UnityEngine;
using System.Collections;

public class unlockButtonExtension : mainMenu
{

	

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void OnGUI ()
		{
	
				//Unlock Button
	
				GUI.skin = unlockButtonSkin;
				if (GUI.Button (new Rect ((Screen.width / 2) - 50, Screen.height / 2 + 100, 100, 50), "")) {
			
						gameStart = false;
						isDone = true;
			
						Destroy (background);
						Application.LoadLevel ("Unlocks");
			
				}
		}
}
