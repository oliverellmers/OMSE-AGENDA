﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleBGVisibility : MonoBehaviour {

    private Image image;

	// Use this for initialization
	void Start () {
        image = transform.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetVisibility(bool b){
        image.enabled = b;
        /*
        if(b){
            image.enabled = false;
        }else{
            image.enabled = true;
        }
        */
    }
}
