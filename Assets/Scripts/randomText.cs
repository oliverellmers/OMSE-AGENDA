using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Twity.DataModels.Responses;

public class randomText : MonoBehaviour {

	public bool useAPI = true;
	public float spaceWidth = 0.01f;
	public GameObject parent;
	public GameObject newT;
	public Canvas textCanvas;
	public Text text;
	public string[] textItems;
	public string key, secret, accesstoken;
	[SerializeField]
	Twitter.Tweet[] tweets;


	private float spacing = 0f;
	private int randomIndex;

	// Use this for initialization
	void Start () {

		if (!useAPI) {

			GetComponent<Text> ().text = System.DateTime.Now.ToString ("HH : mm : ss");

//			randomIndex = Random.Range (0, (textItems.Length - 1));
//			string txtx = textItems [randomIndex];
//			string[] txtxS = txtx.Split (' ');
//			for (var i = 0; i < txtxS.Length; i++) {
//				var wordCount = (txtxS [i].Length + 1) * spaceWidth;
//				//GameObject txt = Instantiate (newT, new Vector3 (spacing, -0.5f, 0.5f), newT.transform.rotation, transform) as GameObject;
//				GetComponent<Text> ().text = txtxS [i];
//				//spacing = spacing + wordCount;
//
//			}
		} else {

			accesstoken = Twitter.API.GetTwitterAccessToken (key, secret);

			tweets = Twitter.API.SearchForTweets ("#cats", accesstoken, 5, Twitter.API.SearchResultType.mixed);

			string tweet = tweets [randomIndex].text;
			string[] tweetS = tweet.Split (' ');
			for (var i = 0; i < tweet.Length; i++) {
				var wordCount = (tweetS [i].Length + 1) * spaceWidth;
				GameObject txt = Instantiate (newT, new Vector3 (spacing, -0.5f, 0.5f), newT.transform.rotation, transform) as GameObject;
				txt.gameObject.GetComponent<Text> ().text = tweetS [i];
				spacing = spacing + wordCount;
		
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
