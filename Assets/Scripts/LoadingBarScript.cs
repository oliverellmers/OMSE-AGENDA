using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class LoadingBarScript : MonoBehaviour {

    AsyncOperation ao;
    public GameObject loadingScreenBG;
    public Slider progBar;
    public Text loadingText;
    public CanvasGroup loadingItemsCG;
    public float fadeTimeIn = 0.5f;
    public float fadeTimeOut = 2.0f;
    public string nextSceneName = "";

    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);

        if (SceneManager.GetActiveScene().name == nextSceneName) {
            FadeLoadingItems(false);
        }
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Start () {
        DontDestroyOnLoad(this);

        loadingItemsCG.alpha = 0f;
        LoadLevel01();
        FadeLoadingItems(true);

    }
	
	void Update () {
		
	}

    public void LoadLevel01() {

        loadingText.text = "LOADING";
        StartCoroutine(LoadLevelWithRealProgress());
    }

    IEnumerator LoadLevelWithRealProgress() {
        yield return new WaitForSecondsRealtime(1f);
        ao = SceneManager.LoadSceneAsync(1);
        ao.allowSceneActivation = false;

        while (!ao.isDone) {
            progBar.DOValue(ao.progress, 0.2f).SetEase(Ease.OutQuad);

            if (ao.progress == 0.9f) {
                progBar.DOValue(1f, 0.2f).SetEase(Ease.OutQuad);
                loadingText.text = "LOADED";
                yield return new WaitForSeconds(0.75f);
                ao.allowSceneActivation = true;
            }

            Debug.Log("progress: " + ao.progress);
            yield return null;
        }
    }

    private void FadeLoadingItems(bool b) {
        StartCoroutine(DOFadeLoadingItems(b));
    }

    IEnumerator DOFadeLoadingItems(bool b) {
        if (b) {
            loadingItemsCG.DOFade(1f, fadeTimeIn).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(fadeTimeIn);
        }
        else {
            loadingItemsCG.DOFade(0f, fadeTimeOut).SetEase(Ease.OutCubic);
            yield return new WaitForSeconds(fadeTimeOut);
            GameObject.Destroy(transform.gameObject);
        }
        
    }
}




