using UnityEngine;
using System.Collections;


public class Falling2 : Falling {
	
//x:0  y:10  z -2

	
	// Use this for initialization
	
	void Start () {
		transform.position = new Vector2 (0, 45);
		//gameObject.renderer.material.color = Color.blue;
	}
	
	// Update is called once per frame
	
	void Update () {
		transform.Translate(Vector2.up * Time.deltaTime * fallSpeed *-1, Space.World);	
		//speedIncrease1 += Time.deltaTime;
	}


	void OnTriggerStay2D (Collider2D col)
	{
		if ((col.gameObject.tag == "Indicator")&& (isReady == false)
		    && (isPressed == true)) {						
			
			Destroy (gameObject);
			
			score++;
			isPressed = false;
			//isDepleted = true;
			//cooldown = true;
			//Debug.Log(spawnSpeed);
		}
		

		
		
	}
//	void speedIncrease()
//	{
//		if (speedIncrease1 >= 5.0f) {
//			spawnSpeed = 0.75f;
//		}
//	}



				
	}


