using UnityEngine;
using System.Collections;

public class darkRedController : gameOver {
	public GameObject darkRedBackground;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
				if (gameOver.isReady == true) {

			transform.position = new Vector3 (0, 10,-2);
				}
		}
}
