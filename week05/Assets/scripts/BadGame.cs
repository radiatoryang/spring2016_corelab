using UnityEngine;
using System.Collections;

public class BadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// if we loaded the game in nightmare mode, set the cube to red
		if ( GameManager.useNightmareMode == true ) {
			GetComponent<Renderer>().material.color = Color.red;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.R ) ) { // go back to main menu
			Application.LoadLevel( "titleScreen" );
		}
	}
}
