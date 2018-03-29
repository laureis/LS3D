using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.root.position.x,0,transform.root.position.z);
	}
}
