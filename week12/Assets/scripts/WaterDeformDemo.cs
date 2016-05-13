using UnityEngine;
using System.Collections;

public class WaterDeformDemo : MonoBehaviour {

	public float waveFrequency = 1f;
	public float waveHeight = 0.5f;

	MeshFilter meshFilter; // meshFilter tells Unity which model to use
	Vector3[] unchangedVertices; // keep a "clean" copy of the vertex info

	void Start () {
		meshFilter = GetComponent<MeshFilter>();
		unchangedVertices = meshFilter.mesh.vertices.Clone() as Vector3[];
	}

	void Update () {
		// step 1: make a clean copy of the vertices to work from
		Vector3[] deformedVertices = unchangedVertices.Clone() as Vector3[];

		// step 2: deform the vertices using ***MATH!!!!***
		for ( int i=0; i<deformedVertices.Length; i++ ) {
			deformedVertices[i] += Vector3.up * 
				Mathf.Sin( waveFrequency * (Time.time + i) ) * waveHeight;
		}

		// step 3: put the vertices back into the mesh
		meshFilter.mesh.vertices = deformedVertices;

		// step 4: recalculate "normals", which tell Unity which way a polygon is facing
		meshFilter.mesh.RecalculateNormals();

		// step 5: scroll the material's "offset"
		GetComponent<Renderer>().material.mainTextureOffset += 
					new Vector2( -Time.deltaTime, Time.deltaTime ) * 0.5f;

		// step 6: put the deformed mesh into the MeshCollider as well
		GetComponent<MeshCollider>().sharedMesh = meshFilter.mesh;
	}
}
