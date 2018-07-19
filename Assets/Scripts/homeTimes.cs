using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class homeTimes : MonoBehaviour {

    public Text t0;

	public Text t1; //sydney +9
    public Text t2; //tokyo +8
    public Text t3; //hk +7
    public Text t4; //dubai +3
    public Text t5; //cape town +1
    public Text t6; //paris + 1

    public Text t7; //iceland -1
    public Text t8; //rio -4
    public Text t9; //new york -5
    public Text t10; //mexico city -6
    public Text t11; //LA -8
    public Text t12; //hawaii -11

    private string[] times;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int hour = System.DateTime.Now.Hour;
        int min = System.DateTime.Now.Minute;
        int sec = System.DateTime.Now.Second;

        t0.GetComponent<Text>().text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");



        float t1H = hour + 9;
        if(t1H > 24) { t1H -= 24; }
        t1.GetComponent<Text> ().text = t1H.ToString("00") + ":" + min.ToString("00");

        float t2H = hour + 8;
        if (t2H > 24) { t2H -= 24; }
        t2.GetComponent<Text>().text = t2H.ToString("00") + ":" + min.ToString("00");

        float t3H = hour + 7;
        if (t3H > 24) { t3H -= 24; }
        t3.GetComponent<Text>().text = t3H.ToString("00") + ":" + min.ToString("00");

        float t4H = hour + 3;
        if (t4H > 24) { t4H -= 24; }
        t4.GetComponent<Text>().text = t4H.ToString("00") + ":" + min.ToString("00");

        float t5H = hour + 1;
        if (t5H > 24) { t5H -= 24; }
        t5.GetComponent<Text>().text = t5H.ToString("00") + ":" + min.ToString("00");

        float t6H = hour + 1;
        if (t6H > 24) { t6H -= 24; }
        t6.GetComponent<Text>().text = t6H.ToString("00") + ":" + min.ToString("00");



        float t7H = hour - 1;
        if (t7H < 0) { t7H += 24; }
        t7.GetComponent<Text>().text = t7H.ToString("00") + ":" + min.ToString("00");

        float t8H = hour - 4;
        if (t8H < 0) { t8H += 24; }
        t8.GetComponent<Text>().text = t8H.ToString("00") + ":" + min.ToString("00");

        float t9H = hour - 5;
        if (t9H < 0) { t9H += 24; }
        t9.GetComponent<Text>().text = t9H.ToString("00") + ":" + min.ToString("00");

        float t10H = hour - 6;
        if (t10H < 0) { t10H += 24; }
        t10.GetComponent<Text>().text = t10H.ToString("00") + ":" + min.ToString("00");

        float t11H = hour - 8;
        if (t11H < 0) { t11H += 24; }
        t11.GetComponent<Text>().text = t11H.ToString("00") + ":" + min.ToString("00");

        float t12H = hour - 11;
        if (t12H < 0) { t12H += 24; }
        t12.GetComponent<Text>().text = t12H.ToString("00") + ":" + min.ToString("00");


	}
}
