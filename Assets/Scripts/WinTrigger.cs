using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {
	public GameObject WinText;

	private bool triggered = false;

	void OnTriggerEnter(Collider other) {

		if (triggered) {
			return;
		}
		//Debug.Log ("Collided with " + other.gameObject.name); 

		//VRTK script adds the collider so we can't just use its tag
		if (other.gameObject.name.Contains("BodyColliderContainer")) {
			triggered = true;
			WinText.SetActive (true);
		}
	}
}
