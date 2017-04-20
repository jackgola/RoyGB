using UnityEngine;
using System.Collections;

public class highScore : Falling
{
		public static float playerHighScore = 0;
// Use this for initialization
		void Start ()
		{
		
		}
	
// Update is called once per frame
		void Update ()
		{
// This controls the high score 		
				if (score >= playerHighScore)
						playerHighScore = score;
// This controls the pixelTheme						
				if (playerHighScore >= 5) 
						highscore25 = true;	
// This controls the snowTheme
				if (playerHighScore >= 10) 
						highscore50 = true;
// This controls the lowpolyTheme
				if (playerHighScore >= 15)
						highscore75 = true;											
			
				

		}
}
