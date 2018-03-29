using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxChange : MonoBehaviour {

	public Material newSkybox;
	int frame;
	int timer;
	// Use this for initialization
	void Start () {

		timer = Random.RandomRange (190, 200);
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (frame == timer) {
			RenderSettings.skybox = newSkybox;
		}
	}
}
