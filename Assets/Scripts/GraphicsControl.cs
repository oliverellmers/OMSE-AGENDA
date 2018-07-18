using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GraphicsControl : MonoBehaviour {

    public float transitionTime;


    //public RectTransform menuButton;
    //public RectTransform menuButtonImage;
    //public Vector2 menuButton_openSizeDelta;
    //public RectTransform menuButtonXX;
    //public CanvasGroup menuButtonNumbers;

    public RectTransform scanButton;
    public RectTransform scanButtonFill;
    public RectTransform scanButtonStroke;
    public Vector2 scanButton_openSizeDelta;

    public RectTransform logoIcon;
    public RectTransform logoIconEyeL;
    public RectTransform logoIconEyeR;

    public CanvasGroup infoOverlay;
    //public RectTransform infoXBtn;

    public CanvasGroup instructionsOverlay;

    public CanvasGroup ARCanvas;

    /*
    public CanvasGroup instructionCanvasGroup;
    public Text instructionsText;
    public string[] instructions;
    */



    private Vector2 menuButton_originalSizeDelta;



    void Start() {

        infoOverlay.blocksRaycasts = false;
        infoOverlay.interactable = false;
        infoOverlay.alpha = 0.0f;

        //menuButton_originalSizeDelta = menuButton.sizeDelta;
        //menuButtonImage.localScale = new Vector2(0f, 0f);
        //menuButtonNumbers.interactable = false;
        //menuButtonNumbers.blocksRaycasts = false;
        //menuButtonNumbers.alpha = 0f;

        scanButtonFill.localScale = new Vector2(0f, 0f);
        scanButtonStroke.localScale = new Vector2(0f, 0f);

        logoIcon.localScale = new Vector2(0f, 0f);
        logoIconEyeL.localScale = new Vector2(0f, 0f);
        logoIconEyeR.localScale = new Vector2(0f, 0f);

        AnimateGraphicsIn();
        //ShowInstructions();

        ShowHideInstructions(true);

        ARCanvasDisplay(false);


    }

    private void AnimateGraphicsIn() {

        StartCoroutine(GraphicsStartAnimationsEnum());
    }

    IEnumerator GraphicsStartAnimationsEnum() {

        logoIcon.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        yield return new WaitForSeconds(transitionTime / 5);
        logoIconEyeL.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        yield return new WaitForSeconds(transitionTime / 5);
        logoIconEyeR.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        yield return new WaitForSeconds(transitionTime / 2);


        scanButtonFill.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        scanButtonStroke.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        yield return new WaitForSeconds(transitionTime / 2);

        //menuButtonImage.DOScale(new Vector2(1f, 1f), transitionTime).SetEase(Ease.InCubic);
        //menuButtonImage.DOLocalRotate(new Vector3(0f, 0f, 360f), transitionTime * 2f, RotateMode.FastBeyond360).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(transitionTime);
    }

    /*
    public void ScaleMenuButtonY(bool b) {
        StartCoroutine(ScaleMenuButtonEnumY(b));
    }

    IEnumerator ScaleMenuButtonEnumY(bool b) {
        if (b) {
            //menuButton.DOSizeDelta(menuButton_openSizeDelta, transitionTime).SetEase(Ease.OutCubic);
            //menuButtonXX.DOLocalRotate(new Vector3(0f, 0f, 45f), transitionTime, RotateMode.FastBeyond360).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(0.1f);

            //menuButtonNumbers.interactable = true;
            //menuButtonNumbers.blocksRaycasts = true;
            //menuButtonNumbers.DOFade(1f, transitionTime);
        }
        else {

            menuButtonNumbers.interactable = false;
            menuButtonNumbers.blocksRaycasts = false;
            menuButtonNumbers.DOFade(0f, transitionTime);
            yield return new WaitForSeconds(0.1f);

            menuButton.DOSizeDelta(menuButton_originalSizeDelta, transitionTime).SetEase(Ease.OutBounce);
            menuButtonXX.DOLocalRotate(new Vector3(0f, 0f, 0f), transitionTime, RotateMode.FastBeyond360).SetEase(Ease.OutBounce);
        }
        yield return new WaitForSeconds(transitionTime);
    }
    */

    public void ScaleScanButton() {
        StartCoroutine(ScaleScanButtonEnum());
    }

    IEnumerator ScaleScanButtonEnum() {

        scanButtonStroke.DOScale(new Vector2(1.2f, 1.2f), transitionTime * 0.5f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(transitionTime * 0.5f);
        scanButtonStroke.DOScale(new Vector2(1f, 1f), transitionTime * 0.5f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(transitionTime * 0.5f);
    }

    public void InfoPanelDisplay(bool b)
    {
        StartCoroutine(DoInfoPanelDisplay(b));
    }

    IEnumerator DoInfoPanelDisplay(bool b)
    {
        if (b)
        {
            infoOverlay.blocksRaycasts = true;
            infoOverlay.interactable = true;
            infoOverlay.DOFade(1.0f, transitionTime);
        }
        else {
            infoOverlay.blocksRaycasts = false;
            infoOverlay.interactable = false;
            infoOverlay.DOFade(0.0f, transitionTime);
        }

        yield return new WaitForSeconds(transitionTime);
    }

    public void ARCanvasDisplay(bool b)
    {
        StartCoroutine(DOARCanvasDisplay(b));
    }

    IEnumerator DOARCanvasDisplay(bool b)
    {
        if (b)
        {
            ARCanvas.blocksRaycasts = true;
            ARCanvas.interactable = true;
            ARCanvas.DOFade(1.0f, transitionTime);
        }
        else
        {
            ARCanvas.blocksRaycasts = false;
            ARCanvas.interactable = false;
            ARCanvas.DOFade(0.0f, transitionTime);
        }

        yield return new WaitForSeconds(transitionTime);
    }

    //text instructions opacity with target detection - fade out after 5-10 seconds, X to close
    /*
    public void ShowInstructions() {

        //TODO: this to be determined by trackable object
        instructionsText.text = instructions[0];

        StartCoroutine(DoShowInstructions());
    }

    IEnumerator DoShowInstructions() {
        instructionCanvasGroup.DOFade(1.0f, transitionTime);
        yield return new WaitForSeconds(10f);
        instructionCanvasGroup.DOFade(0.0f, transitionTime);
    }
    */

    public void OpenOMSEWebsite() {
        Application.OpenURL("https://omsetype.co/rsvp");
    }



    //bool isSpinning = false;
    //Coroutine spinCoroutine;
    public void SpinCloseInfoButton() {
        /*
        if (isSpinning)
        {
            StopCoroutine(spinCoroutine);
        }
        else {
            spinCoroutine = StartCoroutine(DoSpinCloseInfoButton());
            isSpinning = true;
        }
        */
        //StartCoroutine(DoSpinCloseInfoButton());
    }

    /*
    IEnumerator DoSpinCloseInfoButton() {

        infoXBtn.DOLocalRotate(new Vector3(0f, 0f, 360f), transitionTime * 2f, RotateMode.FastBeyond360).SetEase(Ease.OutCubic);
        yield return new WaitForSeconds(transitionTime * 2.0f);
    }
    */

    public void ShowHideInstructions(bool b) {
        StartCoroutine(DOShowHideInstructions(b));
    }

    IEnumerator DOShowHideInstructions(bool b) {

        if (b)
        {
            instructionsOverlay.interactable = true;
            instructionsOverlay.blocksRaycasts = true;
            instructionsOverlay.DOFade(1f, transitionTime);
        }
        else {
            instructionsOverlay.interactable = false;
            instructionsOverlay.blocksRaycasts = false;
            instructionsOverlay.DOFade(0f, transitionTime);
        }
        yield return new WaitForSeconds(transitionTime);
    }




}
