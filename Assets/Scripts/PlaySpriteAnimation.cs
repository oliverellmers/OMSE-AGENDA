using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpriteAnimation : MonoBehaviour {

    public Animator anim;
    public string animStateName;
    public int animLayer = 0;

    public void PlayAnim() {
        Debug.Log("Bang");
        anim.Play(animStateName, animLayer);
    }
}
