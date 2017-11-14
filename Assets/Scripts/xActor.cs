using UnityEngine;

public class XActor  {
	public string name {get; set;} 
	public string mbox {get; set;} 

	public XActor (string name, string mbox) {
		this.name = name;
		this.mbox = mbox;
	}

	public string toJSONstring() {
		return "\"actor\": {\"name\": \"" + name + 
			"\",\"mbox\": \"mailto:" + mbox + "\"}";
	}
}