using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSender : MonoBehaviour {
//	string verbID = "http://activitystrea.ms/schema/1.0/start";
//	string verbDisplay = "started";
//
//	string verbID = "http://activitystrea.ms/schema/1.0/complete";
//	string verbDisplay = "completed";

	public string verbID;
	public string verbDisplay;

	public string activityID = null;
	public string activityName;

	public bool includeResult = true;

	public bool includeCompletion = true;
	public bool completion = true;

	public bool includeSuccess = true;
	public bool success = true;

	public bool includeScore = true;
	public double score = 0.0;

	public bool includeValue = false;
	public string value;

	void SendStatement() {
		XStatement stmt = new XStatement ();
		stmt.actor = new XActor (XAPIsettings.username, XAPIsettings.mbox);
		if (activityID == null || activityID == "") {
			activityID = XAPIsettings.activityID;
		}
		if (activityName == null || activityName == "") {
			activityName = XAPIsettings.activityName;
		}

		stmt.verb = new XVerb (verbID, verbDisplay);

		stmt.obj = new XObject (activityID, activityName);
		stmt.result = new XResult (includeResult, includeCompletion, completion, includeSuccess, success, includeScore, score, includeValue, value);

		string json = stmt.toJSONstring();

		Debug.Log (json);

		XAPIhelper.instance.SaveStatement (json);
	}
}
