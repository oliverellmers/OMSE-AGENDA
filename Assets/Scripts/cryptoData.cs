using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class cryptoData : MonoBehaviour {

	public GameObject cryptoText1;
    public GameObject cryptoText2;
    public GameObject cryptoText3;
    public GameObject cryptoText4;

	private JSONNode cryptoJSON;
    private string BTC;
	private string ETH;
	private string XRP;
    private string BCH;


	void Start () {
		
		StartCoroutine(GetCryptoData());
	}


	IEnumerator GetCryptoData() {


        UnityWebRequest www = UnityWebRequest.Get("https://api.coinmarketcap.com/v2/ticker/?limit=4");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
 
            // Or retrieve results as binary data
            string results = www.downloadHandler.text;
            JSONNode jsonNode = SimpleJSON.JSON.Parse(results);

            JSONNode coins = jsonNode["data"];

            BTC = "$" + coins[0]["quotes"]["USD"]["price"];
            ETH = "$" + coins[1]["quotes"]["USD"]["price"];
            XRP = "$" + coins[2]["quotes"]["USD"]["price"];
            BCH = "$" + coins[3]["quotes"]["USD"]["price"];

            Debug.Log(BTC+" "+ETH+" "+XRP+" "+BCH);

            cryptoText1.GetComponent<Text>().text = "BTC     " + BTC;
            cryptoText2.GetComponent<Text>().text = "ETH     " + ETH;
            cryptoText3.GetComponent<Text>().text = "XRP     " + XRP;
            cryptoText4.GetComponent<Text>().text = "BCH     " + BCH;

			}

        yield return new WaitForSeconds(30);
        StartCoroutine(GetCryptoData());
    }
}
