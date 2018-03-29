using UnityEngine;
using System.Collections;

public class randomAudio : MonoBehaviour
{

	public AudioSource audio;
	public AudioClip[] texts;
	public int frame = 0;
	public int r;

	void Start() {
		frame = 0;
		audio = GetComponent<AudioSource>();
		r = Random.Range(50,100);
	}

	void Update() {
		frame++;
		if (frame == r) {
			float p = Random.Range (0.5F, 1F);
			audio.pitch = p;
			int sound = Random.Range(0, texts.Length);
			audio.PlayOneShot(texts[sound], 1F);
			r = Random.Range(frame, frame+1000);
		}
	}
}