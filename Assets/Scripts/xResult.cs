public class XResult {
	public bool includeResult = true;

	public bool includeCompletion = true;
	public bool completion = true;

	public bool includeSuccess = true;
	public bool success = true;

	public bool includeScore = true;
	public double score = 0.0;

	public bool includeValue = true;
	public string value;

	public XResult ()
	{
		includeResult = false;
	}

	public XResult (bool includeResult, bool includeCompletion, bool completion, bool includeSuccess, bool success, bool includeScore, double score, bool includeValue, string value)
	{
		this.includeResult = includeResult;
		this.includeCompletion = includeCompletion;
		this.completion = completion;
		this.includeSuccess = includeSuccess;
		this.success = success;
		this.includeScore = includeScore;
		this.score = score;
		this.includeValue = includeValue;
		this.value = value;
	}

	public string ToJSONstring() {
		if (!includeResult) {
			return "";
		}

		string resultString =  ", \"result\": {";
		if (includeCompletion) {
			resultString += "\"completion\": " + completion.ToString().ToLower() + ",";
		}
		if (includeSuccess) {
			resultString += "\"success\": " + success.ToString().ToLower() + ",";
		}
		if (includeScore) {
			resultString += "\"score\": {\"scaled\": " + score + "},";
		}
		if (includeValue) {
			resultString += "\"extensions\": {\"https://rage.e-ucm.es/xapi/ext/value\": \"" + value + "\"},";
		}
		resultString = resultString.Substring (0, resultString.Length - 1);//cut off trailing ,
		resultString += "}";

		return resultString;
	}
}
