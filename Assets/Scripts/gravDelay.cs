using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravDelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (delay ());
	}
	

	void Update() {
		if (GetComponent<MeshRenderer> ().enabled == false) {
			GetComponent<Rigidbody> ().isKinematic = true;
		} else {
			GetComponent<Rigidbody> ().isKinematic = false;
		}
	}

	IEnumerator delay() {
		yield return new WaitForSeconds (1);
		GetComponent<Rigidbody> ().isKinematic = false;
	}
}
