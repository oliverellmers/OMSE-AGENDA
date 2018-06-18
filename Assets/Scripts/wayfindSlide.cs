using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wayfindSlide : MonoBehaviour {

	public string txt;

	private int startNum = 0;
	private int stringLength;
	private string newString;

	// Use this for initialization
	void Start () {
		stringLength = txt.Length;
		StartCoroutine (anim ());
	}
	
	// Update is called once per frame
	IEnumerator anim () {
		newString = "";
		for (int i = 0; i < stringLength; i++) {
			var nextChar = startNum + i;
			if (nextChar > stringLength-1) {
				nextChar = nextChar - stringLength;
			}
			newString = newString + txt [nextChar];
		}
		GetComponent<Text> ().text = newString;

		startNum--;

		if (startNum < 0) {
			startNum = stringLength-1;
		}

		yield return new WaitForSeconds(0.2f);
		StartCoroutine (anim ());
	}
}
