using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScale : MonoBehaviour {

	public GameObject cam;
	//public GameObject marker;
	public float scale = 10;
	public float minDist = 1;
	public float maxDist = 2;
	public int fontHigh = 100;
	public int fontLow = 12;
	public int boxHigh = 1200;
	public int boxLow = 0;

	public int boxHeight = 900;

	public bool invert = false;

	private Text m_Text;
	private int newFontSize;
	private int newBoxSize;


	// Use this for initialization
	void Start () {
		m_Text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 camPos = cam.transform.position;
		float dist = Vector3.Distance(camPos, transform.position);
		Debug.Log (dist);
		if (dist >= minDist) {
			if (dist <= maxDist) {
				float scale = (dist - minDist) / (maxDist - minDist);
				if (invert) {
					newFontSize = Mathf.RoundToInt (fontHigh - (scale * (fontHigh - fontLow)));
					newBoxSize = Mathf.RoundToInt ((scale * (boxHigh - boxLow)) + boxLow);
				} else {
					newFontSize = Mathf.RoundToInt ((scale * (fontHigh - fontLow)) + fontLow);
					newBoxSize = Mathf.RoundToInt (boxHigh - (scale * (boxHigh - boxLow)));
				}

			} else {
				newFontSize = fontHigh;
			}

		} else {
			newFontSize = fontLow;
		}
			
		m_Text.fontSize = newFontSize;
		GetComponent<RectTransform>().sizeDelta = new Vector2(newBoxSize , boxHeight);
        Debug.Log("GetComponent<RectTransform>().sizeDelta: " + GetComponent<RectTransform>().sizeDelta);
	}
}
