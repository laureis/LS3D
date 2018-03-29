using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMap : MonoBehaviour {

	public GameObject[] prefabs;
	public int randomPrefab;
	Vector3 pos;
	public GameObject terrain;
	public int yes;
	// Use this for initialization
	float distance;
	int randomY;
	public GameObject player;
	Vector3 initialPosition;
	public Transform clones;

	public GameObject[] allChildren;

	bool dest;
	bool resetM;

	void Start () {
		resetM = false;
		dest = false;
	}

	void Update () {


		distance = Vector3.Distance (player.transform.position, this.transform.position);
		//Debug.Log (distance);
		if (distance < 80f) {
			dest = true;
			resetM=true;
		}

		if (dest) DestroyClones ();
		if(resetM) resetMap();

	}


	void resetMap() { 

		player.transform.position = initialPosition;

		float min_x = -terrain.transform.localScale.x;
		float min_z = -terrain.transform.localScale.z;
		float max_x = terrain.transform.localScale.x;
		float max_z = terrain.transform.localScale.z;

					
			float currentX = -min_x;
			float currentZ = min_z;
			float decalage = 200 / 10;
			for (int i = 0; i <20; i++) {

				for (int j = 0; j <20; j++) {

					yes = Random.Range (0, 3);
					randomY = Random.Range (0,100);
					if (yes == 1) {
						randomPrefab = Random.Range (0, prefabs.Length);
						pos = new Vector3 (currentX, randomY, currentZ);
						GameObject tree2 = (GameObject)Instantiate (prefabs [randomPrefab], pos, transform.rotation);
						tree2.transform.parent = clones;
					}
					currentX += decalage;
				}
				currentX = -min_x;
				currentZ += decalage;
		
		}
		clones.position= new Vector3(clones.position.x-254,clones.position.y ,clones.position.z-133);
		resetM = false;
	}

	void DestroyClones() { 

		foreach (Transform child in clones)
		{
			Destroy(child.gameObject);
		}
		dest = false;
	}
}
