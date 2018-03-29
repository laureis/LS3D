using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine;


public class randomTexture : MonoBehaviour {

	// Use this for initialization
	public Material[] materials = new Material[10];
	public Renderer[] allChildren;
	public int frame = 0;
	public int[] timers;
	int size;
	int currentPosition = 0;
	int r;

	void Start () {
		allChildren = GetComponentsInChildren<Renderer> ();
		size = allChildren.Length;
		timers = new int[size];
		for (int j = 0; j < size; j++) {
			timers [j] = UnityEngine.Random.Range (250 , 1000);
		}
		Array.Sort(timers);
	}

	// Update is called once per frame
	void Update () {

		if (isDone () == false) { 
			if (frame == timers [currentPosition]) {

				Renderer child = allChildren [currentPosition];
				Material[] mats = new Material[child.materials.Length];
				for (int i = 0; i < child.materials.Length; i++) {
					r = UnityEngine.Random.Range (0, materials.Length);
					mats [i] = materials [r];
				}
				allChildren [currentPosition].materials = mats;
				currentPosition++;
			} else
				frame++;
		}
	}

	bool isDone() {
		return (currentPosition >= size);
	}

	void shuffleChilds() {


	}
}
