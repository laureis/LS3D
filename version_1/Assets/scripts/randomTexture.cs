using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;


public class randomTexture : MonoBehaviour {
	
	// Use this for initialization
	public Material[] materials = new Material[10]; 
	int r,timeToWait;
	public Renderer[] allChildren;
	public bool test =true;
	public int timer;
	public int frame =0;
	void Start () {
		

		timer = Random.Range (60, 1000);
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (frame==timer) {
			Renderer[] allChildren = GetComponentsInChildren<Renderer> ();

			foreach (Renderer child in allChildren) {
				Material[] mats = new Material[child.materials.Length];
				for (int j = 0; j < child.materials.Length; j++) {
					r = Random.Range (0, materials.Length);
					mats [j] = materials [r];
				}
				child.materials = mats;
			}

			test = false;
		}

	}


	IEnumerator GenerateTexture(int r, int j, Material[] materials,Renderer child, Material[] mats) {
			r = Random.Range (0, materials.Length);
			mats [j] = materials [r];
			timeToWait = Random.Range (0, 1);
			yield return new WaitForSeconds(timeToWait);
	}
}
