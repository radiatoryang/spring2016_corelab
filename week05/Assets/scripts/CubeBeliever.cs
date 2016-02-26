using UnityEngine;
using System.Collections;

public class CubeBeliever : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate( 0f, CubeGod.instance.godHappiness, 0f );
	}
}
