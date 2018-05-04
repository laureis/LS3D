using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSkybox : MonoBehaviour {

	// Use this for initialization

	public Material[] skybox = new Material[4];
	int init;
	int count;
	int tmp;
	void Start () {

		init = Random.Range (0, skybox.Length);
		RenderSettings.skybox = skybox[init];
	}

	// Update is called once per frame
	void Update () {
		count++;
		if (count == 200) {

			count = 0;
			tmp = Random.Range (0, skybox.Length);
			while (tmp == init) tmp = Random.Range (0, skybox.Length);
			RenderSettings.skybox = skybox[tmp];
			init = tmp;
		}
	}
}
