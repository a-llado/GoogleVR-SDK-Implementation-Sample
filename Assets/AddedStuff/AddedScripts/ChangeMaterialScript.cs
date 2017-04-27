using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialScript : MonoBehaviour {

	public int iPhotoID;

	[SerializeField]
	Material M1;

	[SerializeField]
	Material M2;

	[SerializeField]
	Material M3;

	[SerializeField]
	Material M4;

	Skybox sSkybox;

	bool bAudioEnabled;

	public GameObject AudioSources;

	void Start()
	{
		iPhotoID = 0;
		sSkybox = GetComponent<Skybox> ();
	}

	// Use this for initialization
	public void ChangeMaterial()
	{
		switch (iPhotoID) 
		{
		case 0:
			sSkybox.material = M1;
			break;
		case 1:
			sSkybox.material = M2;
			break;
		case 2:
			sSkybox.material = M3;
			break;
		case 3:
			sSkybox.material = M4;
			break;
		}
	}

	public void NextPhoto(){
		iPhotoID++;

		if (iPhotoID > 3)
			iPhotoID = 0;
		
		ChangeMaterial ();
	}

	public void PrevPhoto(){
		iPhotoID--;

		if (iPhotoID < 0)
			iPhotoID = 3;
		
		ChangeMaterial ();
	}

	public void ChangeAudio(){
		switch (bAudioEnabled) {
		case true:
			AudioSources.SetActive (false);
			bAudioEnabled = false;
			break;
		case false:
			AudioSources.SetActive (true);
			bAudioEnabled = true;
			break;
		}
	}
}
