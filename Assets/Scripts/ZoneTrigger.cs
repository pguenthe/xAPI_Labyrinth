using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneTrigger : MonoBehaviour {
	public bool oneTime;

	private bool triggered = false;

	void OnTriggerEnter(Collider other) {
		if (oneTime && triggered) {
			return;
		}
		//Debug.Log ("Collided with " + other.gameObject.name); 

		//VRTK script adds the collider so we can't just use its tag
		if (other.gameObject.name.Contains("BodyColliderContainer")) {
			triggered = true;
			this.GetComponentInParent<StatementSender> ().SendMessage ("SendStatement");
		}
	}
}
