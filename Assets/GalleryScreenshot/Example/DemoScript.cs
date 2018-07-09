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

    public Image screenshot;
	
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
	}

    IEnumerator FlashScreenShotCanvas() {

        yield return new WaitForEndOfFrame();
        screenshot.DOFade(0f, 1.25f);
        yield return new WaitForSeconds(1.25f);
    }


	public void OnSaveImagePress()
	{
		ScreenshotManager.SaveImage(texture, "MyImage", "MyImages", "png");
	}

	void ScreenshotTaken(Texture2D image)
	{
		console.text += "\nScreenshot has been taken and is now saving...";
		screenshot.sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(.5f, .5f));
        screenshot.color = new Color(1f, 1f, 1f, 0f);
        //screenshot.DOColor(new Color(1f, 1f, 1f, 0f), 2f);
		ui.alpha = 1;
        uiB.alpha = 1;
        //uiC.alpha = 1;
        StartCoroutine(FlashScreenShotCanvas());
    }
	
	void ScreenshotSaved(string path)
	{
		console.text += "\nScreenshot finished saving to " + path;
	}
	
	void ImageSaved(string path)
	{
		console.text += "\n" + texture.name + " finished saving to " + path;
	}
}