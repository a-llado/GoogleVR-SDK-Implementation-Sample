using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehaviuor : MonoBehaviour {

	Vector3 fMoving;

	// Use this for initialization
	void Start () {
		fMoving = new Vector3 (0, 0.1f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePos = (new Vector3(0, 0, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);

		Quaternion current = transform.localRotation;

		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime / 3);
		transform.Translate(0, 0, 4 * Time.deltaTime);	}
}
