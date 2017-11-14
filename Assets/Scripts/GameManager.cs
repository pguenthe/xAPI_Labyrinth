using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager gm;

	public InputField emailField;
	public InputField nameField;

	void Start() {
		gm = this;
	}

	void Update() {
		XAPIsettings.username = nameField.text; 
		XAPIsettings.mbox= emailField.text;
	}
}
