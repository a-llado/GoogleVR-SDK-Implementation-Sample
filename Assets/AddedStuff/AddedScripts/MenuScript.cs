using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	Vector3 vMousePosition;
	Vector3 vToRotate;

	GameObject Player;

	float Timer;

	bool bMouseIsPressed;

	public void LoadGVRDemo(){
		SceneManager.LoadScene ("GVRDemo");
	}

	public void LoadCustomPhotoDemo(){
		SceneManager.LoadScene ("CustomPhotoDemo");
	}

	public void LoadScrollingUIDemo(){
		SceneManager.LoadScene ("ScrollingUIDemo");
	}
		
	public void LoadVideoDemo(){
		SceneManager.LoadScene ("CustomVideoDemo");
	}

	public void LoadMenu(){
		SceneManager.LoadScene ("Menu");
	}

	public void Start(){
		Player = GameObject.FindGameObjectWithTag ("Player");
		Timer = 0;
	}

	public void Update(){

		if (GvrController.AppButtonDown)
			LoadMenu ();

		if (Input.GetMouseButtonDown (0)) {
			vMousePosition = Input.mousePosition;
			bMouseIsPressed = true;
		} else if (Input.GetMouseButtonUp (0)) {
			bMouseIsPressed = false;
		} else if (bMouseIsPressed) {
			vToRotate = Input.mousePosition - vMousePosition;

			Player.transform.Rotate (new Vector3(-vToRotate.y, vToRotate.x, -Player.transform.rotation.eulerAngles.z));
			vMousePosition = Input.mousePosition;
		}
	}
}
