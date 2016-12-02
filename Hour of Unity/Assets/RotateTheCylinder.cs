using UnityEngine;
using System.Collections;

public class RotateTheCylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Starting my Cylinder rotation script");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(1, 1, 0);
	}
}
