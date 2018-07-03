using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpriteAnimation : MonoBehaviour {

    public Animator anim;
    public string animStateName;
    public int animLayer = 0;

    public void PlayAnim(bool b) {
        StartCoroutine(DelayedPlayAnim(b));
    }

    IEnumerator DelayedPlayAnim(bool b) {
        if (b) {
            yield return new WaitForSeconds(0.1f);
            Debug.Log("Bang");
            anim.Play(animStateName, animLayer);
        }
    }
}
