using UnityEngine;

public class XObject {
	public string id {get; set;} 
	public string name {get; set;} 

	public XObject (string id, string definition) {
		this.id = id;
		this.name = definition;
	}

	public string toJSONstring () {
		return "\"object\": {\"id\": \"" + id + 
			"\",\"definition\": {\"name\": { \"" + XAPIsettings.LANGUAGE + "\": \"" +
			name + "\" } } }";
	}
}