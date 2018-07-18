using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class trainTimes : MonoBehaviour {

	public GameObject t1;
	public GameObject t2;

	private JSONNode train1JSON;
	private JSONNode train2JSON;
	private GameObject[] train;
	private string[] dest;
	private string[] plat;
	private int[] timeTill;
	private string[] expTime;
    private int trainNum = 2;


	void Start () {
		train = new GameObject[2];
		dest = new string[2];
		plat = new string[2];
		timeTill = new int[2];
		expTime = new string[2];

		StartCoroutine(GetText());
	}

	IEnumerator GetText() {

        if(GetComponent<Canvas>().enabled){

        UnityWebRequest www = UnityWebRequest.Get("https://api.tfl.gov.uk/StopPoint/910GHOXTON/Arrivals?mode=overground");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
 
            // Or retrieve results as binary data
            string results = www.downloadHandler.text;
            JSONNode jsonNode = SimpleJSON.JSON.Parse(results);

            int lowNum = 10000;
            int lowNum2 = 10000;
            int high1 = 0;
            int high2 = 0;

            if(jsonNode.Count < 2){
                trainNum = 1;
            } else {
                trainNum = 2;
            }

            for(int i = 0; i < jsonNode.Count; i++){

	            if(jsonNode[i]["timeToStation"] < lowNum){
	            	lowNum2 = lowNum;
	            	lowNum = jsonNode[i]["timeToStation"];
	            	high2  = high1;
	            	high1 = i;
	            } else {
	            	if(jsonNode[i]["timeToStation"] < lowNum2){
	            		lowNum2 = jsonNode[i]["timeToStation"];
	            		high2 = i;
	            	}
	            }

	        }

            train1JSON = jsonNode[high1];
			train2JSON = jsonNode[high2];

			train[0] = t1;
			train[1] = t2;

			dest[0] = train1JSON["destinationName"].ToString();
			dest[1] = train2JSON["destinationName"].ToString();

            timeTill[0] = train1JSON["timeToStation"];
            timeTill[1] = train2JSON["timeToStation"];

                for (int i = 0; i < trainNum; i++)
                {
                    if (dest[i].Contains("Clapham Junction Rail Station"))
                    {
                        dest[i] = "CLAPHAM JUNC.";
                        plat[i] = "[P2]";
                    }
                    if (dest[i].Contains("Dalston Junction Rail Station"))
                    {
                        dest[i] = "DALSTON JUNC.";
                        plat[i] = "[P1]";
                    }
                    if (dest[i].Contains("Highbury & Islington Rail Station"))
                    {
                        dest[i] = "ISLINGTON";
                        plat[i] = "[P1]";
                    }
                    if (dest[i].Contains("West Croydon Rail Station"))
                    {
                        dest[i] = "WEST CROYDON";
                        plat[i] = "[P2]";
                    }
                    if (dest[i].Contains("New Cross"))
                    {
                        dest[i] = "NEW CROSS";
                        plat[i] = "[P2]";
                    }
                    if (dest[i].Contains("Crystal Palace"))
                    {
                        dest[i] = "CRYSTAL P.";
                        plat[i] = "[P2]";
                    }


                    System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
                    int curTime = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds + 3600;
                    int tt = curTime + timeTill[i];

                    float minutes = Mathf.Floor(timeTill[i] / 60);
                    float expMin = Mathf.Floor((tt / 60) % 60);
                    float expHour = Mathf.Floor(((tt / 60) / 60) % 24);
                    string expMinS;
                    if(expMin < 10){
                        expMinS = "0" + expMin;
                    } else {
                        expMinS = "" + expMin;
                    }
                    string expHourS;
                    if (expHour < 10)
                    {
                        expHourS = "0" + expHour;
                    }
                    else
                    {
                        expHourS = "" + expHour;
                    }




                    //destination
                    train[i].transform.GetChild(0).GetChild(0).GetComponent<Text>().text = dest[i];
                    train[i].transform.GetChild(1).GetChild(0).GetComponent<Text>().text = dest[i];
                    //platform
                    train[i].transform.GetChild(0).GetChild(1).GetComponent<Text>().text = plat[i];
                    train[i].transform.GetChild(1).GetChild(1).GetComponent<Text>().text = plat[i];
                    //time till
                    if (minutes > 1)
                    {
                        train[i].transform.GetChild(2).GetChild(1).GetComponent<Text>().text = minutes + " MINS";
                        train[i].transform.GetChild(3).GetChild(1).GetComponent<Text>().text = minutes + " MINS";
                    }
                    else
                    {
                        train[i].transform.GetChild(2).GetChild(1).GetComponent<Text>().text = minutes + " MIN";
                        train[i].transform.GetChild(3).GetChild(1).GetComponent<Text>().text = minutes + " MIN";
                    }
                    train[1].transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "ON TIME";
                    //expected time
                    train[i].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "EXP. " + expHourS + ":" + expMinS;

                }

                if(trainNum == 1){

                    //destination
                    train[1].transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "TBC";
                    train[1].transform.GetChild(1).GetChild(0).GetComponent<Text>().text = "TBC";
                    //platform
                    train[1].transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "[P-]";
                    train[1].transform.GetChild(1).GetChild(1).GetComponent<Text>().text = "[P-]";
                    //time till
                    train[1].transform.GetChild(2).GetChild(1).GetComponent<Text>().text = "- MIN";
                    train[1].transform.GetChild(3).GetChild(1).GetComponent<Text>().text = "- MIN";
                    train[1].transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "TBC";
                    //expected time
                    train[1].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "EXP. --:--";
                }


				
			}
        }

        yield return new WaitForSeconds(10);
        StartCoroutine(GetText());
    }
}
