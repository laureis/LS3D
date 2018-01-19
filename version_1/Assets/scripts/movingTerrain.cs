using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTerrain : MonoBehaviour {
	
	public float o = 0;
	public Terrain terrain;
	public SplatPrototype[] splatPrototypes = new SplatPrototype[100];
	// Use this for initialization
	void Start () {
		terrainInfo();

	}
	
	// Update is called once per frame
	void Update () {
		terrainInfo ();	
	}

	void terrainInfo() {

		o++;
		splatPrototypes = terrain.terrainData.splatPrototypes;
		for (int i = 0; i < splatPrototypes.Length; i++) {
			terrain.terrainData.splatPrototypes [i].tileOffset = new Vector2(o, o);
			Debug.Log("OFFSET "+ terrain.terrainData.splatPrototypes [i].tileOffset);
		}
	}
}
