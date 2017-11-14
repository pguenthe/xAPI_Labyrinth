using UnityEngine;

public class XStatement {
	public XActor actor {get; set;} 
	public XVerb verb {get; set;} 
	public XObject obj {get; set;}
	public XResult result { get; set; }

	public System.DateTime timestamp { get; set; }

	public XStatement () {
		actor = null;
		verb = null;
		obj = null;
		result = new XResult();
		timestamp = System.DateTime.UtcNow;
	}

	public XStatement(XActor actor, XVerb verb, XObject obj) {
		this.actor = actor;
		this.verb = verb;
		this.obj = obj;
		result = new XResult();
		timestamp = System.DateTime.UtcNow;
	}

	public string toJSONstring () {
		return "{" + actor.toJSONstring() + ", " + 
			verb.toJSONstring() + ", " + 
			obj.toJSONstring() + 
			result.ToJSONstring() + 
			", \"timestamp\": \"" + timestamp.ToString("s", System.Globalization.CultureInfo.InvariantCulture) + "\"" +
			"}";
	}
}