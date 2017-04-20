using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(AudioSource))]



public class Falling : mainMenu
{
		
		public float spawnSpeedMax ;
		public float spawnSpeedMin;
		public float fallSpeed;
		public GameObject Cube;
		public GameObject Cube2;
		public AudioClip hitSound;
		public static float score;
		public bool cooldown = true;
		
		public static bool isDestroyed = false;

//	public float speedIncrease1 = 0; 
//	public float speedIncrease2;
//	public float speedIncrease3;



		//public static bool cubeDestroyed = false;

		// Use this for initialization

		void Start ()
		{
				transform.position = new Vector2 (0, 45);
				//gameObject.renderer.material.color = Color.blue;
				Invoke ("Spawn", Random.Range (spawnSpeedMin, spawnSpeedMax));
				//76score = 0;

		}
	
		// Update is called once per frame

		void Update ()
		{
				transform.Translate (Vector2.up * Time.deltaTime * fallSpeed * -1, Space.World);
				if (Input.GetKeyDown (KeyCode.Space)) {
						isPressed = true;


				}
				if (Input.GetKey (KeyCode.Space))
						iTimer++;

						
				if (Input.GetKeyUp (KeyCode.Space)) {
						isPressed = false;
						isDepleted = false;
						iTimer = 0;

				}
				if (iTimer >= 750) {
						isDepleted = true;
						isPressed = false;
				}

			
				//speedIncrease1 += Time.deltaTime;
		}

		void Spawn ()
		{
				if (isReady == false)
						Instantiate (Cube, transform.position = new Vector2 (0, 45), Quaternion.identity);
		}
	 
		void OnTriggerStay2D (Collider2D col)
		{
				if ((col.gameObject.tag == "Indicator") && (isReady == false)
						&& (isPressed == true)) {						
						
						Destroy (gameObject);
						isDestroyed = true;
						
						score++;
						isPressed = false;
						//isDepleted = true;
						//cooldown = true;
						//Debug.Log(spawnSpeed);
				}

//		}
//		void speedIncrease()
//	{
//		if (speedIncrease1 == 5.0f) {
//			spawnSpeed = 0.75f;
//				}
//	}
		

			
		}
}

