using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textSpawn : MonoBehaviour {

	public GameObject txt;
	public GameObject plane;
	public float spawnDelay = 1f;
	public Vector3 spawnLoc;
	public string timeVal;

	private Vector3 startPoint;

	void Start () {
		startPoint = transform.position;
		StartCoroutine (spawn ());
	}

	IEnumerator spawn() {

		if (plane.GetComponent<MeshRenderer> ().enabled) {
			startPoint = transform.position + spawnLoc;
			GameObject obj = Instantiate (txt, transform.position, transform.rotation, transform) as GameObject;
			obj.gameObject.transform.GetChild (0).GetComponent<Text> ().text = System.DateTime.Now.ToString (timeVal);
		}


		yield return new WaitForSeconds(spawnDelay);
		StartCoroutine (spawn ());
	}
}
