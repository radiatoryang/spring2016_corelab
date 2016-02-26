using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// "public" means that any other script can talk to this thing
	// "static" means it lives in the code base, not in a scene
	public static bool useNightmareMode = false;

	// Use this for initialization
	void Start () {
		useNightmareMode = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			Application.LoadLevel( "level1" );
		}

		if ( Input.GetKeyDown(KeyCode.N) ) {
			useNightmareMode = true;
			Application.LoadLevel( "level1" );
		}

	}
}
