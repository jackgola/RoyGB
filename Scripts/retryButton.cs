using UnityEngine;
using System.Collections;

public class retryButton : Falling
{
	

		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnGUI ()
		{
				if (isReady == true) {
			if ((GUI.Button (new Rect ((Screen.width/2)-50, Screen.height/2 +100, 100, 50), "Again? (Space)")) || (Input.GetKey(KeyCode.Space))) {
								isReady = false;
								score = 0;
								isPressed = false;
								isDepleted = false;
								iTimer = 0;
								if (classicTheme == true)
										Application.LoadLevel ("classicTheme");
								if (brickTheme == true)
										Application.LoadLevel ("pixelTheme");
								if (snowTheme == true)
										Application.LoadLevel ("snowTheme");
								if (lowpolyTheme == true)
										Application.LoadLevel ("lowpolyTheme");						
						}
			if (GUI.Button (new Rect ((Screen.width/2)-50, (Screen.height/2)+150, 100, 50), "Back to Menu")) {
								score = 0;
								isReady = false;
								Application.LoadLevel ("mainMenu");
						}
			
			

				}
		}
}
