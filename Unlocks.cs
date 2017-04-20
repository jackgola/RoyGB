using UnityEngine;
using System.Collections;

public class Unlocks : mainMenu
{
//variables
		private static bool toggleThemeClassic;
		private static bool toggleThemeBrick;
		public GameObject lock1;
		public GameObject lock2;
		public GameObject lock3;

// Use this for initialization
		void Start ()
		{
		
		}

	
// Update is called once per frame
		void OnGUI ()
		{
				GUI.skin = customToggle;
		
//Main menu buttons for the unlock page
				if (isDone == true) {
						if (GUI.Button (new Rect (345, 400, 100, 50), "Back To Menu"))								
								Application.LoadLevel ("mainMenu");
			
						if (GUI.Toggle (new Rect (345, 150, 150, 150), classicTheme, "          Classic Theme")) {
								classicTheme = true;
								brickTheme = false;
								snowTheme = false;
								lowpolyTheme = false;
						}
// Unlock system is controlled below

// This is for highscore25 aka pixelTheme
						if (highscore25 == false) {
								GUI.color = Color.red;		
								GUI.Label (new Rect (345, 200, 200, 50), "Score 25 to unlock Pixel theme");	
						}
						if (highscore25 == true) {
								Destroy (lock1);			
								GUI.color = Color.white;		
								if (GUI.Toggle (new Rect (345, 200, 110, 50), brickTheme, "Pixel Theme")) {
										classicTheme = false;
										brickTheme = true;
										snowTheme = false;
										lowpolyTheme = false;
								}
						}
// This is for highscore50 aka snowTheme						
						if (highscore50 == false) {
								GUI.color = Color.red;		
								GUI.Label (new Rect (345, 250, 250, 50), "Score 50 to unlock Snow theme");	
						}
						if (highscore50 == true) {
								Destroy (lock2);			
								GUI.color = Color.white;		
								if (GUI.Toggle (new Rect (345, 250, 110, 50), snowTheme, "Snow Theme")) {
										classicTheme = false;
										brickTheme = false;
										snowTheme = true;
										lowpolyTheme = false;
								}
						}
// This is for highscore75 aka lowPolyTheme						
						if (highscore75 == false) {
								GUI.color = Color.red;		
								GUI.Label (new Rect (345, 300, 250, 50), "Score 75 to unlock Low Poly theme");	
						}
						if (highscore75 == true) {
								Destroy (lock3);			
								GUI.color = Color.white;		
								if (GUI.Toggle (new Rect (345, 300, 110, 50), lowpolyTheme, "Low Poly Theme")) {
										classicTheme = false;
										brickTheme = false;
										snowTheme = false;
										lowpolyTheme = true;
								}
						}
				   					
							
							
		
											
								
			
				}
		}
}
