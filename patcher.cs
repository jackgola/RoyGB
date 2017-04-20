using UnityEngine;
using System.Collections;

public class patcher : gameOver {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col)  {
		if (isReady == true)
				transform.position  = new Vector3(0, -9, -10);			
		if (col.gameObject.tag == "Target")
						Destroy (col);
	}
}
