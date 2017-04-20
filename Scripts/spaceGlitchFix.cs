using UnityEngine;
using System.Collections;

public class spaceGlitchFix : MonoBehaviour
{
		public float coolDown = 1f;


		// Use this for initialization
	
	
		// Update is called once per frame
		void Update ()
		{
		if (Input.GetKeyDown (KeyCode.Space))
						Debug.Log ("down");
		if (Input.GetKeyUp (KeyCode.Space))
			Debug.Log ("up");
		}
}


	

