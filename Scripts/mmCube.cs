using UnityEngine;
using System.Collections;

public class mmCube : MonoBehaviour {
	private float fallSpeed = 4;
	public GameObject Cube;
	public float xRange;
	public float yRange;

	// Use this for initialization
	void Start () {
		Invoke ("Spawn", Random.Range (1, 5));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * Time.deltaTime * fallSpeed * -1, Space.World);
	}
	void Spawn() {
		Instantiate (Cube, transform.position = new Vector2 (xRange, yRange), Quaternion.identity);
		}
}
