using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class XAPIhelper : MonoBehaviour {
	public static XAPIhelper instance;

	void Start() {
		instance = this;
	}

	//StartCorouting is an instance method of MonoBehavior so this can't be static
	public void SaveStatement (string json) {
		StartCoroutine(SaveData (json));
	}

	private IEnumerator SaveData(string json) {
		Debug.Log ("Coroutine JSON: " + json);

		string auth = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(XAPIcredentials.KEY + ":" + XAPIcredentials.SECRET));
//		Debug.Log (auth);

		using (UnityWebRequest www = UnityWebRequest.Post(XAPIcredentials.ENDPOINT, "")) {
			//UnityWebRequest's Post method expects form data; we need to use an upload handler for the raw JSON
			UploadHandlerRaw upload= new UploadHandlerRaw(Encoding.UTF8.GetBytes(json));
			www.uploadHandler= upload;

			www.SetRequestHeader("X-Experience-API-Version", "1.0.0");
			www.SetRequestHeader("Authorization", auth);
			www.SetRequestHeader("Content-Type", "application/json");

			Debug.Log ("Contacting server...");

			yield return www.SendWebRequest();

			if (www.isNetworkError || www.responseCode != 200)
			{
				Debug.Log(www.error);
			}
			else
			{
				Debug.Log("Success! " + www.responseCode);
			}
		}	
	}
}