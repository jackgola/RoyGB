using UnityEngine;
using System.Collections;

public class Destroy : Falling
{

/// <summary>
/// for the transparency effect for the destroyerCube use these coordiantes
/// position:  0, -10
/// scale:  100,100
/// </summary>

		// Use this for initialization
		void Start ()
		{
				transform.position = new Vector2 (0, -10);
		}

		

		void Update ()
		{
//		if (Input.GetKey (KeyCode.Space)) {
//			gameObject.renderer.material.color = Color.green;
//						//transform.localScale = new Vector3 (30, 1, 1);
//						
//				}
//		else
//			transform.localScale = new Vector3 (37,1,1);




				if (Input.GetKey (KeyCode.Space))
						gameObject.renderer.material.color = Color.green;
				
				if (isDepleted == true)
						gameObject.renderer.material.color = Color.red;
				if (Input.GetKeyUp (KeyCode.Space))
						gameObject.renderer.material.color = Color.yellow;
						
						
		}
}

							

		
			

	





