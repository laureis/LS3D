using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTextureTerrain : MonoBehaviour {
	int i;
	TerrainData intialTerrain;
	public Terrain terrain;
	int r1,r2,r;
	bool once=true;
	int t;
	// Use this for initialization
	void Start () {

		r = Random.Range (2, 5);
		intialTerrain = terrain.terrainData;
		UpdateTerrainTexture(terrain.terrainData, 0, r);
		r1 = r;
		r = Random.Range (2, 5);
		UpdateTerrainTexture(terrain.terrainData, 1, r);
		r2 = r;
		t = Random.Range (2, 5);
	}
	
	// Update is called once per frame
	void Update () {

		/*i++;
		if (i > 120 && once) {
			UpdateTerrainTexture (terrain.terrainData, r1, 0);
			UpdateTerrainTexture (terrain.terrainData, r2, 1);
			once = false;
		}
		Debug.Log (i);*/

		if (Input.GetKey ("escape")) {
			UpdateTerrainTexture (terrain.terrainData, r1, 0);
			UpdateTerrainTexture (terrain.terrainData, r2, 1);
			Application.Quit ();
		}
		
	}
		
	static void UpdateTerrainTexture(TerrainData terrainData, int textureNumberFrom, int textureNumberTo) {
		//get current paint mask
		float[, ,] alphas = terrainData.GetAlphamaps(0, 0, terrainData.alphamapWidth, terrainData.alphamapHeight);
		// make sure every grid on the terrain is modified
		for (int i = 0; i < terrainData.alphamapWidth; i++)
		{
			for (int j = 0; j < terrainData.alphamapHeight; j++)
			{
				//for each point of mask do:
				//paint all from old texture to new texture (saving already painted in new texture)
				alphas[i, j, textureNumberTo] = Mathf.Max(alphas[i, j, textureNumberFrom], alphas[i, j, textureNumberTo]);
				//set old texture mask to zero
				alphas[i, j, textureNumberFrom] = 0f;
			}
		}
		// apply the new alpha
		terrainData.SetAlphamaps(0, 0, alphas);
	}
}