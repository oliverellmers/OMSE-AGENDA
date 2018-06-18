using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {


	public GameObject cam;
	public float lerpSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 camPos = cam.transform.position;
		transform.position = Vector3.Lerp(transform.position, camPos, lerpSpeed * Time.deltaTime);
	}
}
