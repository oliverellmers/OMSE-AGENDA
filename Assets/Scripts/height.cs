using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class height : MonoBehaviour {

	public GameObject parent;
	public GameObject parent2;
	public float h = 0.1f;
	public float destroyTime = 3;
	public float speed = 0.1f;
	public int fallTime = 300;

	private int count = 0;

	void FixedUpdate () {
		transform.Translate(new Vector3(0,-speed,0) * Time.deltaTime);
		count++;

		if (count > fallTime) {
			count = 0;
			transform.GetComponent<Rigidbody> ().useGravity = true;
			transform.GetComponent<Rigidbody> ().isKinematic = false;
			parent2.transform.SetParent(GameObject.Find ("clock").transform);
				;
			Destroy(transform.parent.gameObject, destroyTime);
		}
	}
}
