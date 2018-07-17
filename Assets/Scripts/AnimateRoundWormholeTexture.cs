using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRoundWormholeTexture : MonoBehaviour {

    public Material mat;
    public float speed = 10f;
    private float deltaTime;
    // Use this for initialization
    void Start () {
        

    }
    float i = 0;
    // Update is called once per frame
    void Update () {
        
        deltaTime = Time.deltaTime;
        mat.SetTextureOffset("_MainTex", new Vector2(i, /*deltaTime * speed*/ 0));
        i+= 0.01f; 
    }
}
