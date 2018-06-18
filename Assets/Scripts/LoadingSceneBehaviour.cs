using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneBehaviour : MonoBehaviour {

    public SceneLoader sceneLoader;
    public float loadDelay;
    public string nextScene;

    void Awake()
    {
        LoadLevel();
    }

    private void LoadLevel()
    {
        //sceneLoader.LoadSceneWithFade(nextScene);
        StartCoroutine(DelayedLoadLevel());
    }

    IEnumerator DelayedLoadLevel()
    {
        yield return new WaitForSeconds(loadDelay);

        sceneLoader.LoadSceneWithFade(nextScene);
    }
}
