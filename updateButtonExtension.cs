using UnityEngine;
using System.Collections;

public class updateButtonExtension : mainMenu
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void OnGUI ()
		{
		
		//Update Log
		
			GUI.skin = updateButtonSkin;
				if (GUI.Button (new Rect ((Screen.width / 2) - 50, (Screen.height / 2) + 150, 100, 50), "")) {
						gameStart = false;
						Destroy (background);
						isDone = true;
						Application.LoadLevel ("whatsNewMenu");
			
				}
		}
}
