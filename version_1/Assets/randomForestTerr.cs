using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomForestTerr : MonoBehaviour {

	public GameObject treePrefab; 
	Vector3 pos;
	public Terrain terrain;
	public int nbTrees;
	// Use this for initialization
	void Start () {

		for(int i=0;i<nbTrees;i++){
			pos=new Vector3(Random.Range(5,55),0,Random.Range(5,55));
			GameObject tree = (GameObject)Instantiate(treePrefab, pos, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

