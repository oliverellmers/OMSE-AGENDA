using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialElementDeleteRuntime : MonoBehaviour {

    private MeshRenderer mr;

	// Use this for initialization
	void Start () {
        mr = transform.GetComponent<MeshRenderer>();
        //mr.materials.RemoveAt(1);

        Material originalMat = mr.materials[1];
        mr.materials = new Material[1];
        mr.materials[0] = originalMat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
