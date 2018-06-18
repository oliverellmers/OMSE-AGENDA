using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beerText : MonoBehaviour {

	public string[] textItems;

	public GameObject[] textRings;

	private int randomIndex;

	// Use this for initialization
	void Start () {
		randomIndex = Random.Range (0, (textItems.Length - 1));
		string txt = textItems [randomIndex];
		for (int i = 0; i < textRings.Length; i++) {
			textRings [i].GetComponent<Text> ().text = txt;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
