using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currentTime : MonoBehaviour {

	//public Text Date;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//int time = System.DateTime.Now;
//		int time2 = Date();
//
//		int day = time.Day;
//		int month = time.Month;
//		int year = dt.Now.Year;
//		int hours = dt.Now.Hour;
//		int minutes = dt.Now.Minute;
//		int seconds = dt.Now.Second;
		//print(System.DateTime.Now.ToString("'TIME'  HH:mm:ss  DATE  dd/MM/18"));
		GetComponent<Text> ().text = System.DateTime.Now.ToString ("HH : mm : ss");
		//Date.GetComponent<Text>().text = System.DateTime.Now.ToString ("DATE   dd / MM / yy");
	}
}
