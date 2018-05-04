using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouringStructure : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			pourStructure();
	}

	void pourStructure () {
		if (transform.position.y > 20) {
			transform.position -= new Vector3 (0, 2f, 0);
			transform.localScale -= new Vector3 (0, 0.01f, 0);
		} else if (transform.localScale.y < -0.15)
			transform.localScale += new Vector3 (0, 0.1f, 0);
	}


}