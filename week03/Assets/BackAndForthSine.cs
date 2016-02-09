using UnityEngine;
using System.Collections;

public class BackAndForthSine : MonoBehaviour {

	Vector3 startPosition;

	void Start () {
		startPosition = transform.position; // remember where we started
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = startPosition 
			+ new Vector3( 0f, 0f, Mathf.Sin(Time.time) * 10f);
	}
}
