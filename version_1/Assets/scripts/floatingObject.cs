using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingObject : MonoBehaviour {

	bool up = false;
	int nbFrames;
	int animation;
	int r;
	int frame;
	public GameObject player;
	void Start () {
		nbFrames = 0;
		animation = Random.Range(0,3);
		r = Random.Range (0, 60);
		frame = 0;
	}
	
	void Update () {


		switch (animation) {

		case 0:
			float d = Random.Range (0.1f,1f);
			if (!up && nbFrames < 60) {
				this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y - d, this.gameObject.transform.position.z);
				nbFrames++;
			}
			if (nbFrames == 60) {
				up = !up;
				nbFrames = 0;
			}
			if (up && nbFrames < 60) {
				this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y + d, this.gameObject.transform.position.z);
				nbFrames++;
			}
			break;

		case 1: 
			if (this.gameObject.transform.position.y > -260) {
				this.gameObject.transform.position -= new Vector3 (0, 2f, 0);
				this.gameObject.transform.localScale -= new Vector3 (0, 0.01f, 0);
			} else if (this.gameObject.transform.localScale.y < -0.15)
				this.gameObject.transform.localScale += new Vector3 (0, 0.1f, 0);
			break;
		case 2:
			frame++;
			if (r == frame) {
				this.GetComponent<Rigidbody> ().isKinematic = false;
				if (transform.position.y == 0)
					Destroy (this.gameObject);
			}
			break;
		}

	}
}
