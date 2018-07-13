using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllTogglesOff : MonoBehaviour {

    public Toggle[] toggles = new Toggle[3];

    private PlaneManager m_planeManager;
    private GroundPlaneUI m_groundPlaneUI;

	// Use this for initialization
	void Start () {
        m_planeManager = GameObject.Find("PlaneManager").GetComponent<PlaneManager>();
        m_groundPlaneUI = GameObject.Find("Behaviour").GetComponent<GroundPlaneUI>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckIfAllTogglesOff(bool b) {
        if (!b) {
            if (!toggles[0].isOn && !toggles[1].isOn && !toggles[2].isOn) {
                Debug.Log("All toggles are off!");
                m_planeManager.SetNoneMode();
                m_groundPlaneUI.AllTogglesOff();
            }
        }
    }
}
