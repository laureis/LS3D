using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnviroment : MonoBehaviour {

	// Use this for initialization
	public GameObject Player;
	private Vector3 positionPlayer;

	public Transform plane;
	private Transform obj1;
	private Transform obj2;
	public Transform[] objects = new Transform[10];

	private bool RightUp, RightDown, LeftUp, LeftDown;

	void Start () {
		RightUp = false;
		RightDown = false;
		LeftUp = false;
		LeftDown = false;
		Player= GameObject.Find("[CameraRig]");
	}

	void GenerateRightUP(float x, float z) {
		if (!RightUp) {
			newPlane (x + 400, z);
			newPlane (x + 400, z + 400);
			newPlane (x, z + 400);
			RightUp = true;
		}
	}//done

	void GenerateRightDown(float x, float z) {
		if (!RightDown) {
			newPlane (x + 400, z);
			newPlane (x + 400, z - 400);
			newPlane (x, z - 400);
			RightDown = true;
		}
	}//done

	void GenerateLeftUP(float x, float z) {	
		if (!LeftUp) {
			newPlane (x - 400, z);
			newPlane (x - 400, z + 400);
			newPlane (x, z + 400);
			LeftUp = true;
		}
	}

	void GenerateLeftDown(float x, float z) {
		if (!LeftDown) {
			newPlane (x - 400, z);
			newPlane (x - 400, z - 400);
			newPlane (x, z - 400);
			LeftDown = true;
		}
	}
		

	void newPlane(float x, float z) {
		int r1 = Random.Range (0, objects.Length);
		obj1 = objects [r1];
		int r2 = Random.Range (0, objects.Length);
		obj2 = objects [r2];
		Instantiate (plane, new Vector3 (x, 0, z), Quaternion.identity);
		Instantiate (obj1, new Vector3 (x + 120, 0, z - 100), Quaternion.identity);
		Instantiate (obj2, new Vector3 (x - 120, 0, z - 100), Quaternion.identity);
	}

	// Update is called once per frame
	/*void Update () {
		positionPlayer = Player.transform.position;
		if (positionPlayer.x < 200f && positionPlayer.x > 10f) {
			if (positionPlayer.y > 10f && positionPlayer.y < 200f) {
				GenerateRightUP (plane.position.x,plane.position.z);
			} else if (positionPlayer.y < -10f && positionPlayer.y > -200f) 
				GenerateRightDown (plane.position.x,plane.position.z);
		}
		else if (positionPlayer.x > -200f && positionPlayer.x < 10f) {
			if (positionPlayer.y > 10f && positionPlayer.y < 200f) {
				GenerateLeftUP (plane.position.x,plane.position.z);
			} else if (positionPlayer.y < -10f && positionPlayer.y > -200f) 
				GenerateLeftDown (plane.position.x,plane.position.z);
		}
	}	*/
}


/*
 * 
 * 	public GameObject[] nextEnviroment = new GameObject[5]; 
	public GameObject currentEnviroment;

	private int NbrOfEnv=30, i,randomEnv;

	private float RandomX,RandomZ;
	public GameObject MainTerrain;
	private Vector3 pos;
		 * Vector3 posUp, posRight, posLeft, posButtom;
			Quaternion rotRight, rotLeft, rotButtom, rotUp;
		 * posRight = new Vector3 (currentEnviroment.transform.position.x, currentEnviroment.transform.position.y + 20, (currentEnviroment.transform.position.z) + 40);
		//rotRight = Quaternion.Euler (new Vector3 (currentEnviroment.transform.position.x, currentEnviroment.transform.position.y + 90, (currentEnviroment.transform.position.z)));
		GameObject Enviroment1 = (GameObject)Instantiate (nextEnviroment [i], posRight);
		posRight = new Vector3 (currentEnviroment.transform.position.x, currentEnviroment.transform.position.y + 8, (currentEnviroment.transform.position.z) + 65);
		//rotRight = Quaternion.Euler (new Vector3 (currentEnviroment.transform.position.x, currentEnviroment.transform.position.y, (currentEnviroment.transform.position.z)));
		GameObject Enviroment2 = (GameObject)Instantiate (nextEnviroment [i], posRight);

			for (int i = 0; i < NbrOfEnv; i++) {
			RandomX = Random.Range (MainTerrain.transform.position.x - 20f, MainTerrain.transform.position.x + 20f);
			RandomZ = Random.Range (MainTerrain.transform.position.z - 20f, MainTerrain.transform.position.z + 20f);
			randomEnv = Random.Range (0, nextEnviroment.Length);
			pos = new Vector3 (RandomX, 0f, RandomZ);
			GameObject Enviroment = (GameObject)Instantiate (nextEnviroment [randomEnv], pos, transform.rotation); 
		}
		 */
