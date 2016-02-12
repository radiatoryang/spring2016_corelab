using UnityEngine;
using System.Collections;

public class RaycastVisibility : MonoBehaviour {

	public Transform cube, sphere; // assign in Inspector
	
	// Update is called once per frame
	void Update () {
		// generate a ray from the cube, going towards the sphere
		Ray ray = new Ray( cube.position, sphere.position - cube.position );
		// calculate the distance between the cube and sphere
		float distanceBetween = Vector3.Distance( cube.position, sphere.position );
		// visualize the raycast we are about to shoot
		Debug.DrawRay( ray.origin, ray.direction.normalized * distanceBetween, Color.yellow );
		// if the cube and sphere *CAN* see each other, then...
		if ( Physics.Raycast( ray, distanceBetween ) == false ) {
			cube.Rotate( 0f, 180f * Time.deltaTime, 0f ); // spin the cube if it can see the sphere
		}
	}
}
