using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour {


	public GameObject player;
	int r, frame;

	// Use this for initialization
	void Start () {
		r = Random.Range (120, 240);
	}
	
	// Update is called once per frame
	/*void Update () {
		frame++;
		if (r == frame) {
			this.transform.position = new Vector3(player.transform.position.x,player.transform.position.y+100f,player.transform.position.z);
			this.GetComponent<Rigidbody> ().isKinematic = false;
			if (player.transform.position.y > this.transform.position.y)
				Destroy (this.gameObject);
		}
	}*/
}
