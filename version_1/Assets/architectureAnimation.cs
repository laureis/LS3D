using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class architectureAnimation : MonoBehaviour {

	Renderer[] allChildren;
	bool up = true; 

	void Start () {

		allChildren = GetComponentsInChildren<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach (Renderer child in allChildren) {
		float r = Random.Range (-1f, 1f);
		child.transform.position += new Vector3 (0, r, 0);
		}	
	}
}