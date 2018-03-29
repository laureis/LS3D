using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


/** Indication pour la team Décalage 3D
* Component required :
* 	- NavMeshAgent
* Manip required :
*   - Selectionné l'objet qui fait office de sol
*   - Window > Navigation >> Onglet "Bake"
*   - Cliquer sur le bouton "Bake" en bas à droite
*/

public class proceduralDeplacement : MonoBehaviour {
	public float deltaTime;
	private float timeSinceLastDirectionChoice;
	private float startTime;

	public float targetDistance;
	private NavMeshAgent agent;
	private int direction;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		agent = GetComponent<NavMeshAgent>();
	}

	// Update is called once per frame
	void Update () {
		timeSinceLastDirectionChoice = Time.time - startTime;
	  if(timeSinceLastDirectionChoice > deltaTime){
			startTime = Time.time;
			Debug.Log(transform.position);

			direction = Random.Range(0,3);
			Debug.Log(direction);

			switch (direction) {
				case 0 :
					agent.SetDestination(transform.position + new Vector3(0,0,targetDistance));
					break;
				case 1 :
					agent.SetDestination(transform.position + new Vector3(0,0,-targetDistance));
					break;
				case 2 :
					agent.SetDestination(transform.position + new Vector3(targetDistance,0,0));
					break;
				default:
					agent.SetDestination(transform.position + new Vector3(-targetDistance,0,0));
					break;
			}
		}
	}
}
