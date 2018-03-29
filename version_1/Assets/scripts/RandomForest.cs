using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForest : MonoBehaviour {


	public GameObject[] prefabs;
	public int randomPrefab;
	Vector3 pos;
	public GameObject terrain;
	public int nbObjects;
	public int yes;
	int randomY;

	public Transform clones;

	// Use this for initialization
	void Start () {

		float min_x = -terrain.transform.localScale.x;
		float min_z = -terrain.transform.localScale.z;
		float max_x = terrain.transform.localScale.x;
		float max_z = terrain.transform.localScale.z;



		float currentX = min_x;
		float currentZ = min_z;
		float decalage = 200 / 10;
		for (int i = 0; i <20; i++) {

			for (int j = 0; j <20; j++) {

				yes = Random.Range (0, 2);
				randomY = Random.Range (0,100);
				if (yes == 1) {
					randomPrefab = Random.Range (0, prefabs.Length);
					pos = new Vector3 (currentX, randomY, currentZ);
					GameObject tree2 = (GameObject)Instantiate (prefabs [randomPrefab], pos, transform.rotation);
					tree2.transform.parent = clones;
				}
				currentX += decalage;
			}
			currentX = 0;
			currentZ += decalage;
		}
		clones.position= new Vector3(clones.position.x-254,clones.position.y ,clones.position.z-133);

	}

}
