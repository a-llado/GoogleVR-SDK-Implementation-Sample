using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public GameObject Audio0;
	public GameObject Audio1;
	public GameObject Audio2;
	public GameObject Audio3;
	public GameObject Audio4;
	public GameObject Audio5;
	public GameObject Audio6;
	public GameObject Audio7;
	public Material Default;
	public Material Reproducing;


	int iAudio;

	float Timer;

	// Use this for initialization
	void Start () {
		iAudio = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		if (Timer >= 2) {
			Timer = 0; 

			iAudio++;

			if (iAudio > 7)
				iAudio = 0;

			switch (iAudio) {
			case 0:
				Audio0.GetComponent<GvrAudioSource> ().Play ();
				Audio0.GetComponent<Renderer> ().material.color = Color.red;
				Audio7.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 1:
				Audio1.GetComponent<GvrAudioSource>().Play ();
				Audio1.GetComponent<Renderer> ().material.color = Color.red;
				Audio0.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 2:
				Audio2.GetComponent<GvrAudioSource>().Play ();
				Audio2.GetComponent<Renderer> ().material.color = Color.red;
				Audio1.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 3:
				Audio3.GetComponent<GvrAudioSource>().Play ();
				Audio3.GetComponent<Renderer> ().material.color = Color.red;
				Audio2.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 4:
				Audio4.GetComponent<GvrAudioSource>().Play ();
				Audio4.GetComponent<Renderer> ().material.color = Color.red;
				Audio3.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 5:
				Audio5.GetComponent<GvrAudioSource>().Play ();
				Audio5.GetComponent<Renderer> ().material.color = Color.red;
				Audio4.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 6:
				Audio6.GetComponent<GvrAudioSource>().Play ();
				Audio6.GetComponent<Renderer> ().material.color = Color.red;
				Audio5.GetComponent<Renderer> ().material.color = Color.white;
				break;

			case 7:
				Audio7.GetComponent<GvrAudioSource>().Play ();
				Audio7.GetComponent<Renderer> ().material.color = Color.red;
				Audio6.GetComponent<Renderer> ().material.color = Color.white;
				break;
			}
		}
	}
}
