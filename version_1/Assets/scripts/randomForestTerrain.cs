using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomForestTerrain : MonoBehaviour {
	bool up = false;
	int nbFrames = 0;
	public GameObject treePrefab; 
	Vector3 pos;
	public Terrain terrain;
	public int nbTrees;
	// Use this for initialization
	void Start () {

		for(int i=0;i<nbTrees;i++){
			pos=new Vector3(Random.Range(terrain.transform.position.x+5,terrain.transform.position.x*2-5),terrain.gameObject.transform.position.y,Random.Range(terrain.transform.position.z+5,terrain.transform.position.z*2-5));
			GameObject tree = (GameObject)Instantiate(treePrefab, pos, transform.rotation);
		}
		pos = new Vector3 (terrain.transform.position.x, terrain.transform.position.y, terrain.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
