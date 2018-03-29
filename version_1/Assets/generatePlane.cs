using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePlane : MonoBehaviour {

	public Transform plane;
	public Transform obj1;
	public Transform obj2;
	public Transform[] objects = new Transform[10];

	// Use this for initialization
	void Start () {
		
	}

	void GenerateRightUp(int x, int z) {
		newPlane (x+400,z);
		newPlane (x+400,z+400);
		newPlane (x,z+400);
	}//done

	void GenerateRightDown(int x, int z) {
		newPlane (x+400,z);
		newPlane (x+400,z-400);
		newPlane (x,z-400);
	}//done

	void GenerateLeftUp(int x, int z) {		
		newPlane (x-400,z);
		newPlane (x-400,z+400);
		newPlane (x,z+400);
	}

	void GenerateLeftDown(int x, int z) {
		newPlane (x-400,z);
		newPlane (x-400,z-400);
		newPlane (x,z-400);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void newPlane(int x, int z) {
		int r1 = Random.Range (0, objects.Length);
		obj1 = objects [r1];
		int r2 = Random.Range (0, objects.Length);
		obj2 = objects [r2];
		Instantiate (plane, new Vector3 (x, 0, z), Quaternion.identity);
		Instantiate (obj1, new Vector3 (x + 120, 0, z - 100), Quaternion.identity);
		Instantiate (obj2, new Vector3 (x - 120, 0, z - 100), Quaternion.identity);
	}


}
