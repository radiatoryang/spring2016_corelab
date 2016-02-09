using UnityEngine;
using System.Collections;

public class BackAndForthLerp : MonoBehaviour {

	public Transform startCube, endCube; // assign in Inspector later

	float progress = 0f;
	
	// Update is called once per frame
	void Update () {
		if ( progress < 1f ) {
			progress += Time.deltaTime; // it'll take 1 second to complete a length
		} else {
			progress = 0f;
		}

		transform.position = Vector3.Lerp( startCube.position, endCube.position, progress );
	}
}
