using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLDgenerateNext : MonoBehaviour {

	public GameObject terrainPrefab;
	public GameObject Player;
	private GameObject [] terrains = new GameObject[10];
	private bool collidedFront, collidedBack;
	private int i,j;
	// Use this for initialization
	void Start () {
		/*
		terrains [0] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, -400), Quaternion.identity);
		terrains [1] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		terrains [2] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 400), Quaternion.identity); */

		terrains [1] = (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, 400), Quaternion.identity);
		terrains [4] = (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, 0), Quaternion.identity);
		terrains [7] = (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, -400), Quaternion.identity);

		terrains [2] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 400), Quaternion.identity);
		terrains [5] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		terrains [8] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, -400), Quaternion.identity);

		terrains [3] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, 400), Quaternion.identity);
		terrains [6] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, 0), Quaternion.identity);
		terrains [9] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, -400), Quaternion.identity);
	}
		
	// Update is called once per frame
	void Update () {

		checkDistance ();
			
	}

	void GenerateArround(int i){
		
		if (i != 5) {
			terrains [5].transform.position = terrains [i].transform.position;
		
			/*for (j = 1; j < 10; j++) {
				if (j != 5){
					Destroy (terrains [j]);
				}
			}*/
			
			terrains [5].transform.position = terrains [i].transform.position;
			terrains [1] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x - 400, 0, terrains [5].transform.position.z + 400), Quaternion.identity);
			terrains [4] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x - 400, 0, 0), Quaternion.identity);
			terrains [7] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x - 400, 0, terrains [5].transform.position.z - 400), Quaternion.identity);

			terrains [2] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x, 0, terrains [5].transform.position.z + 400), Quaternion.identity);
			terrains [8] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x, 0, terrains [5].transform.position.z - 400), Quaternion.identity);

			terrains [3] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x + 400, 0, terrains [5].transform.position.z + 400), Quaternion.identity);
			terrains [6] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x + 400, 0, 0), Quaternion.identity);
			terrains [9] = (GameObject)Instantiate (terrainPrefab, new Vector3 (terrains [5].transform.position.x + 400, 0, terrains [5].transform.position.z - 400), Quaternion.identity);

		}
	}

	void checkDistance() {



		/*if (Player.transform.position.z > terrains [1].transform.position.z+200f || Player.transform.position.x > terrains [1].transform.position.x+200f )  {
			collidedFront = true;
		}

		if (Player.transform.position.z < terrains [1].transform.position.z-200f || Player.transform.position.x < terrains [1].transform.position.x-200f )  {
			collidedBack = true;
		}*/

		if ((Player.transform.position.z < terrains [5].transform.position.z - 200f) && (Player.transform.position.x < terrains [5].transform.position.x + 200f)
		&& (Player.transform.position.x > terrains [5].transform.position.x - 200f)) {
			i=8;
			GenerateArround(i);
			Debug.Log ("b");
		}

		if ((Player.transform.position.z > terrains [5].transform.position.z + 200f) && (Player.transform.position.x < terrains [5].transform.position.x + 200f) 
		&& (Player.transform.position.x > terrains [5].transform.position.x - 200f)) {
			i=2;
			GenerateArround(i);
			Debug.Log ("f");
			}
		if ((Player.transform.position.x > terrains [5].transform.position.x + 200f)&& (Player.transform.position.z < terrains [5].transform.position.z + 200f) &&
		(Player.transform.position.z > terrains [5].transform.position.z - 200f)){
			i=6;
			GenerateArround(i);
			Debug.Log ("r");
		}

		if ((Player.transform.position.x < terrains [5].transform.position.x - 200f)) {
			i=4;
			GenerateArround(i);
			Debug.Log ("l");
		}

	}
}
