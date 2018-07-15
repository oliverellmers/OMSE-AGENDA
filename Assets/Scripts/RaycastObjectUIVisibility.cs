using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastObjectUIVisibility : MonoBehaviour {

    public Camera camera;

    void Start()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            if (objectHit.tag == "ARObject") {
                Debug.Log("I HAVE HIT THE AR OBJECT!!");
            }
            // Do something with the object that was hit by the raycast.
        }
    }
}