using UnityEngine;
using System.Collections;

public class CubeGod : MonoBehaviour {

	public static CubeGod instance;
	public int godHappiness = 0;

	// Use this for initialization
	void Start () {
		instance = this; 
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.G) ) {
			godHappiness++; // pressing G makes the CubeGod happier
		}
	}
}
