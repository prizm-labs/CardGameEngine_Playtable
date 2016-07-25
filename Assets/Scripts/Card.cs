using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class Card : MonoBehaviour {
	public GameObject collidedObject;
	public int DeckLayer = 8;

	void OnEnable() {
		GetComponent<ReleaseGesture> ().Released += ReleaseHandler;
		GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		GetComponent<ReleaseGesture> ().Released -= ReleaseHandler;
		GetComponent<TapGesture> ().Tapped -= TapHandler;
	}


	void OnTriggerEnter(Collider col) {
		/*
		if (col.gameObject.name == "Deck") {
			Debug.LogError ("Collided with deck");
		}
		*/
		collidedObject = col.gameObject;
		/*
		 if (collidedObject.layer == DeckLayer) {
			collidedObject.GetComponent<Deck> ().highlight (Deck.addCardHighlight);
		}
		*/
	}

	void OnTriggerExit(Collider col) {
		/*
		if (col.gameObject.name == "Deck") {
			Debug.LogError ("Collided with deck");
		}
		*/
		/*
		if (collidedObject.layer == DeckLayer) {
			collidedObject.GetComponent<Deck> ().highlight (Deck.defaultHighlight);
		}
		*/
		collidedObject = null;
	}

	public void ReleaseHandler (object sender, System.EventArgs e) {
		if (collidedObject != null && collidedObject.layer == DeckLayer) {
			collidedObject.GetComponent<Deck> ().add (gameObject);
			//collidedObject.GetComponent<Deck> ().highlight (Deck.defaultHighlight);
		}
	}

	public void TapHandler (object sender, System.EventArgs e) {
		iTween.RotateAdd (gameObject, iTween.Hash ("x", 0, "y", 180, "z", 0));
	}

}
