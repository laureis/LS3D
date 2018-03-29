using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionEnvironement : MonoBehaviour {


	float rx1,rz1,rx2,rz2;

	// Use this for initialization
	void Start () {
		rx1 = Random.Range (0, 100);
		rz1 = Random.Range (25, 125);
		rx2 = Random.Range (-100, 0);
		rz2 = Random.Range (80, 120);
		if (this.name == "environement1") {
			this.transform.position = new Vector3 (rx1, transform.position.y, rz1);
		}
		if (this.name == "environement2") {
			this.transform.position = new Vector3 (rx2, transform.position.y, rz2);
			Debug.Log (this.transform.position);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
