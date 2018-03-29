using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class blowWorld : MonoBehaviour {

	bool babyBlow;
	public GameObject room;
	int r;
	public GameObject Player;
	float distance;
	bool once;

	// Use this for initialization
	void Start () {
		babyBlow = false;
		//Player = GameObject.Find ("[CameraRig]");
		once = true;
		room=GameObject.Find ("blow");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (Player.transform.position, room.transform.position);
		//Debug.Log (Player.transform.position);
		if (distance<20f && once) {

			Debug.Log ("I am in BABY");
			r = Random.Range (1, 6);
			if(r>0)	room.GetComponent<PlayableDirector> ().Play();
			r = 0;
			once = false;
		}
		if (distance > 100f) {
			once = true;
		}
	}
}
