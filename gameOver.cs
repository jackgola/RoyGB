using UnityEngine;
using System.Collections;

public class gameOver : Falling
{	
		
		
	//public static  bool isReady = false;
//	public bool scoreReset = false;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
//		if (scoreReset == true)
//						score = 0;
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				if (col.gameObject.tag == "Target") {
						
						//score--;
						
						Destroy(col.gameObject);
						
						isReady = true;
						Input.ResetInputAxes();
						Application.LoadLevel("gameOverScreen");
						
						//transform.position = new Vector3 (0, 10,-2);
			
			
						//Instantiate (darkRedBackground, transform.position = new Vector3 (0, 10, -2), Quaternion.identity);
				}
		}
}
