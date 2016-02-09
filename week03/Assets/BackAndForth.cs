using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour {

	Vector3 moveDirection = new Vector3(0, 0, 1f);
	
	// Update is called once per frame
	void Update () {
		transform.position += moveDirection * Time.deltaTime * 10f;

		if ( transform.position.z > 10f ) {
			moveDirection = new Vector3( 0f, 0f, -1f);
			// transform.position.z -= 1f; // THIS DOES NOT WORK
		}

		if ( transform.position.z < -10f ) {
			moveDirection = new Vector3( 0f, 0f, 1f );
		}
	}
}
