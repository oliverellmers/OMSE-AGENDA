using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CanvasGroupVisible : MonoBehaviour {

    private CanvasGroup canvasGroup;
    public float transitionTime = 0.25f;

	// Use this for initialization
	void Start () {
        canvasGroup = transform.GetComponent<CanvasGroup>();
        DisplayCanvasGroup(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisplayCanvasGroup(bool b){
        StartCoroutine(DODisplayCanvasGroup(b));
    }

    IEnumerator DODisplayCanvasGroup(bool b){
        if(b){
            canvasGroup.DOFade(1f, transitionTime);
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;

        }else{
            
            canvasGroup.DOFade(0f, transitionTime);
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        yield return new WaitForSeconds(transitionTime);
    }
}
