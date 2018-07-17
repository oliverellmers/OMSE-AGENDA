using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using DG.Tweening;

public class DemoScript : MonoBehaviour {

	public bool hideGUI = false;
	public Texture2D texture;
	public Text console;
	public CanvasGroup ui;
    public CanvasGroup uiB;
    public CanvasGroup uiC;
    public CanvasGroup uiD;

    public Image screenshot;
    public Text screenShotText;
	
	void OnEnable ()
	{
		// call backs
		ScreenshotManager.OnScreenshotTaken += ScreenshotTaken;
		ScreenshotManager.OnScreenshotSaved += ScreenshotSaved;	
		ScreenshotManager.OnImageSaved += ImageSaved;
	}

	void OnDisable ()
	{
		ScreenshotManager.OnScreenshotTaken -= ScreenshotTaken;
		ScreenshotManager.OnScreenshotSaved -= ScreenshotSaved;	
		ScreenshotManager.OnImageSaved -= ImageSaved;
	}

	public void OnSaveScreenshotPress()
	{
		ScreenshotManager.SaveScreenshot("AGENDA_ScreenShot", "AGENDA", "jpeg");
		if(hideGUI) ui.alpha = 0;
        if (hideGUI) uiB.alpha = 0;
        if (hideGUI) uiC.alpha = 0;
        if (hideGUI) uiD.alpha = 0;
    }

    IEnumerator FlashScreenShotCanvas() {

        yield return new WaitForEndOfFrame();
        screenshot.DOFade(1f, 0.35f).SetEase(Ease.InElastic);
        screenShotText.DOFade(1f, 0.35f).SetEase(Ease.InElastic);
        yield return new WaitForSeconds(0.35f);
        screenshot.DOFade(0f, 3.0f).SetEase(Ease.OutCubic);
        screenShotText.DOFade(0f, 3.0f).SetEase(Ease.OutCubic);
        yield return new WaitForSeconds(3.0f);
    }


	public void OnSaveImagePress()
	{
		ScreenshotManager.SaveImage(texture, "MyImage", "MyImages", "png");
        //ScreenshotTaken();

    }

	void ScreenshotTaken(Texture2D image)
	{
		console.text += "\nScreenshot has been taken and is now saving...";
		screenshot.sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(.5f, .5f));
		ui.alpha = 1;
        uiB.alpha = 1;
        uiD.alpha = 1;
        StartCoroutine(FlashScreenShotCanvas());
        //StartCoroutine(DODoColor());
    }

    /*
    IEnumerator DODoColor() {
        screenshot.DOColor(new Color(0.5f, 0.5f, 0.5f, 0f), 2f);
        screenShotText.DOColor(new Color(0.5f, 0.5f, 0.5f, 0f), 2f);
        yield return new WaitForSeconds(2f);

    }*/
	
	void ScreenshotSaved(string path)
	{
		console.text += "\nScreenshot finished saving to " + path;
	}
	
	void ImageSaved(string path)
	{
		console.text += "\n" + texture.name + " finished saving to " + path;
	}
}