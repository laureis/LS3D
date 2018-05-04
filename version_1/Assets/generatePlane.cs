using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePlane : MonoBehaviour {

		/*
		 * LEFT_UP UP RIGHT_UP
		 * LEFT CENTER RIGHT 
		 * LEFT_DOWN DOWN RIGHT_DOWN
		 * 
		
		 0 3 6 
		 1 4 7
		 2 5 8
		 * 
		 
		 */

	public enum  e_plane {
		CENTER, UP, DOWN, LEFT, RIGHT, LEFT_UP, RIGHT_UP, LEFT_DOWN, RIGHT_DOWN, OOPS
	}
	
	public GameObject[] terrainPrefabs = new GameObject[3];
	public GameObject player;
	private GameObject[] terrains = new GameObject[9];
	private GameObject terrainPrefab;
	
	
	void Start () {
		
		// one random terrain out of 3 possibilities per game ! 
		terrainPrefab = terrainPrefabs[Random.Range(0,terrainPrefabs.Length)];
		
		// left
		terrains [0] = (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, 400), Quaternion.identity);
		terrains [1] = (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, 0), Quaternion.identity);
		terrains [2]= (GameObject) Instantiate (terrainPrefab, new Vector3 (-400, 0, -400), Quaternion.identity);
		
		// center
		terrains [3] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 400), Quaternion.identity);
		terrains [4] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		terrains [5] = (GameObject) Instantiate (terrainPrefab, new Vector3 (0, 0, -400), Quaternion.identity);
 
		// right
		terrains [6] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, 400), Quaternion.identity);
		terrains [7] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, 0), Quaternion.identity);
		terrains [8] = (GameObject) Instantiate (terrainPrefab, new Vector3 (400, 0, -400), Quaternion.identity);

	}

	void Update () {
		
		generateNext(whereIsUser());
	}
	
	
	e_plane intToEnum(int n) {
		
		switch(n) {
			
			case 0: return e_plane.LEFT_UP;
				break;
			case 1: return e_plane.LEFT;
				break;
			case 2: return e_plane.LEFT_DOWN;
				break;
			case 3: return e_plane.UP;
				break;
			case 4: return e_plane.CENTER;
				break;
			case 5: return e_plane.DOWN;
				break;
			case 6: return e_plane.RIGHT_UP;
				break;
			case 7: return e_plane.RIGHT;
				break;
			case 8: return e_plane.RIGHT_DOWN;
				break;
			default: return e_plane.OOPS;
		}
	}
	
	// retourne le plane dans lequel se trouve l'utilisateur
	e_plane whereIsUser() {
	
		for (int i = 0; i < terrains.Length; i++) {
		
			if ((player.transform.position.x <= terrains[i].transform.position.x + 200f) && 
				(player.transform.position.x >= terrains[i].transform.position.x - 200f) && 
				(player.transform.position.z <= terrains[i].transform.position.z + 200f) && 
				(player.transform.position.z >= terrains[i].transform.position.z - 200f))
			return intToEnum(i);
		}
		return e_plane.OOPS;
	}
	
	void generateNext(e_plane currentPosition) {
		
		switch(currentPosition) {
			
			case e_plane.UP :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x, 0, terrains[i].transform.position.z+400);
				}
				break;
				
			case e_plane.DOWN :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x, 0, terrains[i].transform.position.z-400);
				}
				break;
				
			case e_plane.RIGHT :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x+400, 0, terrains[i].transform.position.z);
				}
				break;
				
			case e_plane.LEFT :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x-400, 0, terrains[i].transform.position.z);
				}
				break;
				
			case e_plane.RIGHT_UP :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x+400, 0, terrains[i].transform.position.z+400);
				}
				break;
				
			case e_plane.LEFT_UP :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x-400, 0, terrains[i].transform.position.z+400);
				}
				break;
				
			case e_plane.RIGHT_DOWN :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x+400, 0, terrains[i].transform.position.z-400);
				}
				break;
			case e_plane.LEFT_DOWN :
				for (int i = 0; i < terrains.Length; i++) {
					terrains[i].transform.position = new Vector3 (terrains[i].transform.position.x-400, 0, terrains[i].transform.position.z-400);
				}
				break;
			default:return;
		}
	}
}
