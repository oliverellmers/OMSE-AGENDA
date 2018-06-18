using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCameraRotation : MonoBehaviour {

    public Transform camTransform;
	
	// Update is called once per frame
	void Update () {
        transform.localRotation = camTransform.localRotation;
	}
}
