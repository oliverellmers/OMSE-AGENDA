using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidHide : MonoBehaviour {

	MeshRenderer meshR;

	// Use this for initialization
	void Start () {
		meshR = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("hide");
		meshR.enabled = false;
		transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("show");
		meshR.enabled = true;
		transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = true;
	}
}
