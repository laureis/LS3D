using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTextureTerrain : MonoBehaviour {
	
	public Terrain terrain;
	
	public int timer;
	public int frame;
	int totalTexture = 6;
	int nextTexture;
	void Start () {
		
		nextTexture = Random.Range(1,totalTexture);
		timer = Random.Range (500, 1000);
	}

	void Update () {
		
		frame++;
		if (frame == timer) {
			
			UpdateTerrainTexture (terrain.terrainData, 0, nextTexture);
			nextTexture = Random.Range(1, totalTexture);
			frame = 0;
			timer = Random.Range (500, 1000);
		}
		
		if (Input.GetKey ("escape")) {
			UpdateTerrainTexture (terrain.terrainData, nextTexture, 0);
			Application.Quit();
		}

	}

	void UpdateTerrainTexture(TerrainData terrainData, int textureNumberFrom, int textureNumberTo) {

		//get current paint mask
		float[, ,] alphas = terrainData.GetAlphamaps (0, 0, terrainData.alphamapWidth, terrainData.alphamapHeight);
		// make sure every grid on the terrain is modified
		for (int i = 0; i < terrainData.alphamapWidth; i++) {
			for (int j = 0; j < terrainData.alphamapHeight; j++) {
				//for each point of mask do:
				//paint all from old texture to new texture (saving already painted in new texture)
				alphas [i, j, textureNumberTo] = Mathf.Max (alphas [i, j, textureNumberFrom], alphas [i, j, textureNumberTo]);
				//set old texture mask to zero
				alphas [i, j, textureNumberFrom] = 0f;
			}
		}
		// apply the new alpha
		terrainData.SetAlphamaps (0, 0, alphas);
	}
}