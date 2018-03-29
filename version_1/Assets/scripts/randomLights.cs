using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomLights : MonoBehaviour {

	public Light[] lights;
	float r, v, b;
	void Start()
	{
		lights = FindObjectsOfType(typeof(Light)) as Light[];
		foreach (Light light in lights)
		{
			if (light.tag == "Light") {
				r = Random.Range (0F, 1F);
				v = Random.Range (0F, 1F);
				b = Random.Range (0F, 1F);
				light.color = new Color (r,v,b);
			}
		}
	}
}
