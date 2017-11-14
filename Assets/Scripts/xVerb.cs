using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XVerb {
	public string id {get; set;} 
	public string display {get; set;} 

	public XVerb (string id, string display) {
		this.id = id;
		this.display = display;
	}

	public string toJSONstring () {
		string verbString = 
			"\"verb\": {\"id\": \"" + id +
			"\", \"display\": { \"" +
			XAPIsettings.LANGUAGE + "\": \"" + display + "\" }}";
		return verbString;
	}
}
