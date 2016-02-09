using UnityEngine;
using System.Collections;

public class VectorDemo : MonoBehaviour {

	public float speed = 2.562f;
	public Transform lookTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Time.deltaTime = the duration of the frame in seconds
		// 10 FPS, dT = 0.1s
		// 100 FPS, dT = 0.01s
		// Time.deltaTime makes things "framerate independent"
		transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;

		// rotate 90 degrees per second on the Y axis
		transform.Rotate( 0f, 90f * Time.deltaTime, 0f );
		// OY-ler
		transform.localEulerAngles += new Vector3( 0f, 90f * Time.deltaTime, 0f );
		// these lines of code do the same thing

		// you don't have to use trig to make something look at something
		// transform.LookAt( lookTarget ); 
	}
}
