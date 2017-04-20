using UnityEngine;
using System.Collections;

public class pixelThemeController : MonoBehaviour {
	
	private static Color darkRed = new Color (60, 0, 0 ,0.9f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
			camera.backgroundColor = darkRed;
//		if (Input.GetKeyUp(KeyCode.Space))
//			camera.backgroundColor = Color.Lerp (Color.green, Color.green, 1f);	
	}
}
