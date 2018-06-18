using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Virtence.VText;

public class MobileKeyPadVtext : MonoBehaviour {

    public VTextInterface[] m_vTextInterface = new VTextInterface[2];
    public string textToDisplay = "";

    private TouchScreenKeyboard keyboard;
	// Use this for initialization
	void Start () {
        foreach (VTextInterface vText in m_vTextInterface) {
            vText.RenderText = textToDisplay;
        }
    }
	
	// Update is called once per frame
	void Update () {

     
        foreach (VTextInterface vText in m_vTextInterface)
        {
            vText.Rebuild();
        }


    }

    void LateUpdate()
    {
        Loom.QueueOnMainThread(() => {
            foreach (VTextInterface vText in m_vTextInterface)
            {
                if (null != vText)
                {
                    vText.RenderText = keyboard.text;
                }
            }
        });
    }

    public void ShowKeypad() {
        keyboard = TouchScreenKeyboard.Open(textToDisplay, TouchScreenKeyboardType.Default, false, false, false);

        /*
        if (keyboard != null) {
            textToDisplay = keyboard.text;
        }
        */
    }
}
