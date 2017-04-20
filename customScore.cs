using UnityEngine;
using System.Collections;

public class customScore : highScore
{


		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (gameOver.isReady == true) {
			//transform.position = new Vector2(0.5f,0.85f);

			guiText.fontSize = 30;
			guiText.text = "YOUR FINAL SCORE WAS\n" + score + "\n\n\n YOUR HIGH SCORE IS\n" + playerHighScore;
//			const float highScore = score;
//				if (highScore < score)
//				highScore = score;
						
					
				} 
						
		}
}

//	void OnGUI()
//	{
//		
//		GUI.Label (new Rect(Screen.width - 215,150,100,100), score.ToString ());
//	}

