using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class weatherData : MonoBehaviour {

	public GameObject tempText;

	private JSONNode weatherJSON;
    private string temp;


	void Start () {
		
		StartCoroutine(GetWeatherData());
	}


	IEnumerator GetWeatherData() {

        UnityWebRequest www = UnityWebRequest.Get("http://api.openweathermap.org/data/2.5/weather?q=london&APPID=461d798635bfa85e683b407a31984d8a");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
 
            // Or retrieve results as binary data
            string results = www.downloadHandler.text;
            JSONNode jsonNode = SimpleJSON.JSON.Parse(results);

            JSONNode weather = jsonNode;

            char upArrow = '\u00B0';
            temp = Mathf.RoundToInt(weather["main"]["temp"]-273) + upArrow.ToString() + "C";

            Debug.Log(weather["main"]);

            tempText.GetComponent<Text>().text = temp;

			}

        yield return new WaitForSeconds(60);
        StartCoroutine(GetWeatherData());
    }
}
