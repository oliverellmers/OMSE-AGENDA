using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LoadingScreenAnimation : MonoBehaviour {

    public RectTransform topText;
    public RectTransform btmText;

    private Vector2 topTextEndPosition = new Vector2(0f, 0f);
    private Vector2 btmTextEndPosition = new Vector2(0f, 0f);

    private Vector2 topTextStartPosition = new Vector2(-750f, 0f);
    private Vector2 btmTextStartPosition = new Vector2(450f, 0f);

    // Use this for initialization
    void Start () {

        topText.anchoredPosition = topTextStartPosition;
        btmText.anchoredPosition = btmTextStartPosition;
        StartCoroutine(AnimateTextIn());
	}

    IEnumerator AnimateTextIn() {
        yield return new WaitForSeconds(0.25f);

        topText.DOAnchorPos(topTextEndPosition, 0.25f);
        yield return new WaitForSeconds(0.125f);
        btmText.DOAnchorPos(btmTextEndPosition, 0.25f);
        yield return new WaitForSeconds(0.275f);
    }
	
}
