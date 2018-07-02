using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SwitchARContentManagement : MonoBehaviour {

    //[HideInInspector]
    //public bool isContentA = true;
    [SerializeField]
    private GameObject ARContentA;
    [SerializeField]
    private GameObject ARContentB;

    private PlaneManager m_planeManagerA, m_planeManagerB;
    private AnchorInputListenerBehaviour m_anchorInputListenerBehaviourA, m_anchorInputListenerBehaviourB;
    private PlaneFinderBehaviour m_planeFinderBehaviourA, m_planeFinderBehaviourB;
    private ContentPositioningBehaviour m_contentPositioningBehaviourA, m_contentPositioningBehaviourB;
    private AnchorBehaviour m_anchorBehaviourA, m_anchorBehaviourB;
    private ProductPlacement m_productPlacementA, m_productPlacementB;
    private TouchHandler m_touchHandlerA, m_touchHandlerB;


    // Use this for initialization
    void Start () {
        m_planeManagerA = ARContentA.GetComponentInChildren<PlaneManager>();
        m_planeManagerB = ARContentB.GetComponentInChildren<PlaneManager>();

        m_anchorInputListenerBehaviourA = ARContentA.GetComponentInChildren<AnchorInputListenerBehaviour>();
        m_anchorInputListenerBehaviourB = ARContentB.GetComponentInChildren<AnchorInputListenerBehaviour>();

        m_planeFinderBehaviourA = ARContentA.GetComponentInChildren<PlaneFinderBehaviour>();
        m_planeFinderBehaviourB = ARContentB.GetComponentInChildren<PlaneFinderBehaviour>();

        m_contentPositioningBehaviourA = ARContentA.GetComponentInChildren<ContentPositioningBehaviour>();
        m_contentPositioningBehaviourB = ARContentB.GetComponentInChildren<ContentPositioningBehaviour>();

        m_anchorBehaviourA = ARContentA.GetComponentInChildren<AnchorBehaviour>();
        m_anchorBehaviourB = ARContentB.GetComponentInChildren<AnchorBehaviour>();

        m_productPlacementA = ARContentA.GetComponentInChildren<ProductPlacement>();
        m_productPlacementB = ARContentB.GetComponentInChildren<ProductPlacement>();

        m_touchHandlerA = ARContentA.GetComponentInChildren<TouchHandler>();
        m_touchHandlerB = ARContentB.GetComponentInChildren<TouchHandler>();

        TurnOffB();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TurnOffBehaviour(bool b) {
        if (b)
        {
            TurnOnB();
            TurnOffA();
        }
        else {
            TurnOnA();
            TurnOffB();
        }
    }

    private void TurnOnA() {
        m_planeManagerA.enabled = true;
        m_anchorInputListenerBehaviourA.enabled = true;
        m_planeFinderBehaviourA.enabled = true;
        m_contentPositioningBehaviourA.enabled = true;
        m_anchorBehaviourA.enabled = true;
        m_productPlacementA.enabled = true;
        m_touchHandlerA.enabled = true;
    }
    private void TurnOffA()
    {
        m_planeManagerA.enabled = false;
        m_anchorInputListenerBehaviourA.enabled = false;
        m_planeFinderBehaviourA.enabled = false;
        m_contentPositioningBehaviourA.enabled = false;
        m_anchorBehaviourA.enabled = false;
        m_productPlacementA.enabled = false;
        m_touchHandlerA.enabled = false;
    }

    private void TurnOnB()
    {
        m_planeManagerB.enabled = true;
        m_anchorInputListenerBehaviourB.enabled = true;
        m_planeFinderBehaviourB.enabled = true;
        m_contentPositioningBehaviourB.enabled = true;
        m_anchorBehaviourB.enabled = true;
        m_productPlacementB.enabled = true;
        m_touchHandlerB.enabled = true;
    }
    private void TurnOffB()
    {
        m_planeManagerB.enabled = false;
        m_anchorInputListenerBehaviourB.enabled = false;
        m_planeFinderBehaviourB.enabled = false;
        m_contentPositioningBehaviourB.enabled = false;
        m_anchorBehaviourB.enabled = false;
        m_productPlacementB.enabled = false;
        m_touchHandlerB.enabled = false;
    }
}


