using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour
{
// Standard variables
		public static bool isDepleted = false;
		public static float iTimer;
		public static bool isPressed = false;
		public bool gameStart;
		public GameObject background;
		public static bool isReady = false;
		public static bool isDone = false;
// booleans for the themes		 
		public static bool classicTheme = true;
		public static bool brickTheme = false;
		public static bool snowTheme = false;
		public static bool lowpolyTheme = false;
// booleans for the score for each theme (in order)		
		public static bool highscore25 = false;
		public static bool highscore50 = false;
		public static bool highscore75 = false;
		public static bool highscore100 = false;
// Custom GUI skins
		public GUIStyle customButton;
		public GUISkin playButtonSkin;		
		public GUISkin unlockButtonSkin;
		public GUISkin updateButtonSkin;
		public GUISkin customToggle;
		
		

// Use this for initialization
		void Start ()
		{
				gameStart = true;
		}
	
// Update is called once per frame
		void Update ()
		{
			
		}
// All GUI stuff below this point
		void OnGUI ()
		{
				if (gameStart == true) {
 //This makes the "Play" button work
						GUI.skin = playButtonSkin;
						
						//Play button
																										
						if (GUI.Button (new Rect ((Screen.width/2)-50, (Screen.height/2) +50, 100, 50), "")) {
								
								gameStart = false;
								isDone = false;
								isPressed = false;
								Destroy (background);
								isDepleted = false;
								iTimer = 0;
// This loads whichever theme is selected								
								if (classicTheme == true)
										Application.LoadLevel ("classicTheme");
								if (brickTheme == true)
										Application.LoadLevel ("pixelTheme");
								if (snowTheme == true)
										Application.LoadLevel ("snowTheme");
								if (lowpolyTheme == true)
										Application.LoadLevel ("lowpolyTheme");				
						}
						
//			if (GUI.Button (new Rect ((Screen.width/2)-50, (Screen.height/2)+150, 100, 50), "Update Log")) {
//								gameStart = false;
//								Destroy (background);
//								isDone = true;
//								Application.LoadLevel ("whatsNewMenu");
//
//						}
//			if (GUI.Button (new Rect ((Screen.width/2)-50, Screen.height/2 +100, 100, 50), "Unlocks")) {
//									
//								gameStart = false;
//								isDone = true;
//
//								Destroy (background);
//								Application.LoadLevel ("Unlocks");
//
//						}
				}
				
		}
		}

