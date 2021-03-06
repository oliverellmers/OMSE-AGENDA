﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.EventSystems;

public class PauseHitTest : MonoBehaviour /*, IPointerUpHandler, IPointerDownHandler*/
{
    private PlaneManager planeManager;
    private AnchorInputListenerBehaviour anchorInputListenerBehaviour;
    private ContentPositioningBehaviour contentPositioningBehaviour;

    /*
    private bool IsPointerOverUIObject() {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
    */


    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }


    /*
    private bool IsPointerOverGameObject(int fingerId)
    {
        EventSystem eventSystem = EventSystem.current;
        return (eventSystem.IsPointerOverGameObject(fingerId)
            && eventSystem.currentSelectedGameObject != null);
    }
    */


    // Use this for initialization
    void Start () {
        planeManager = transform.GetComponentInParent<PlaneManager>();
        anchorInputListenerBehaviour = transform.GetComponent<AnchorInputListenerBehaviour>();
        contentPositioningBehaviour = transform.GetComponent<ContentPositioningBehaviour>();
        

    }

    // Update is called once per frame
    void Update() {
        if (PlaneManager.planeMode == PlaneManager.PlaneMode.NONE)
            return;

        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
            if (/*IsPointerOverGameObject (Input.GetTouch (0).fingerId)*/ IsPointerOverUIObject()) {
                Debug.Log("Hit UI, Ignore Touch");

                    anchorInputListenerBehaviour.enabled = false;
                    contentPositioningBehaviour.enabled = false;
                } else {
                    Debug.Log("Handle Touch");
                    anchorInputListenerBehaviour.enabled = true;
                    contentPositioningBehaviour.enabled = true;
                }
        } 
        

        //anchorInputListenerBehaviour.enabled = !IsPointerOverUIObject();
        //contentPositioningBehaviour.enabled = !IsPointerOverUIObject();

        //Debug.Log("anchorInputListenerBehaviour.enabled: " + anchorInputListenerBehaviour.enabled);
        //Debug.Log("contentPositioningBehaviour.enabled: " + contentPositioningBehaviour.enabled);


    }
}
