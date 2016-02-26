using UnityEngine;
using System.Collections;

public class PlatformTest : MonoBehaviour {

	public Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator.SetBool( "MakeBridge", false );
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.B) ) {
			myAnimator.SetBool( "MakeBridge", true );
		}

		if ( Input.GetKeyDown(KeyCode.M) ) {
			myAnimator.SetBool( "MakeBridge", false);
		}
	}
}
