using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class airData : MonoBehaviour {

	public GameObject airText1;
    public GameObject airText2;
    public GameObject airText3;

	private JSONNode airJSON;
    private string O3;
	private string PM10;
	private string NO2;


	void Start () {
		
		StartCoroutine(GetAirData());
	}


	IEnumerator GetAirData() {

        UnityWebRequest www = UnityWebRequest.Get("http://api.erg.kcl.ac.uk/AirQuality/Hourly/MonitoringIndex/SiteCode=HK6/Json");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
 
            // Or retrieve results as binary data
            string results = www.downloadHandler.text;
            JSONNode jsonNode = SimpleJSON.JSON.Parse(results);

            JSONNode species = jsonNode[0]["LocalAuthority"]["Site"]["species"];

            NO2 = species[0]["@AirQualityIndex"] + "  " + species[0]["@AirQualityBand"];
            O3 = species[1]["@AirQualityIndex"] + "  " + species[1]["@AirQualityBand"];
            PM10 = species[2]["@AirQualityIndex"] + "  " + species[2]["@AirQualityBand"];

            Debug.Log(NO2+" "+O3+" "+PM10);

            airText1.GetComponent<Text>().text = "INDEX: " + NO2;
            airText2.GetComponent<Text>().text = "INDEX: " + O3;
            airText3.GetComponent<Text>().text = "INDEX: " + PM10;

			}

        yield return new WaitForSeconds(120);
        StartCoroutine(GetAirData());
    }
}
