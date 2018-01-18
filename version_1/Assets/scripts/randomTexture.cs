using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;


public class randomTexture : MonoBehaviour {
	
	// Use this for initialization
	public Material[] materials = new Material[10]; 
	int r;
	void Start () {
	
		Renderer[] allChildren = GetComponentsInChildren<Renderer>();

		foreach (Renderer child in allChildren) {
			var mats = new Material[child.materials.Length];
			for (int j = 0; j < child.materials.Length; j++) {
				r = Random.Range (0, materials.Length);
				mats [j] = materials [r];
			}
			child.materials = mats;
		}			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
}
