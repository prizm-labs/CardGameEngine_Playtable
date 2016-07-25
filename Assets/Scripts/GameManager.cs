using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject testDeck;
	public GameObject testCard;


	void Awake() {
		for (int i = 0; i < 52; i++) {
			/*GameObject newCard = (GameObject) Instantiate (testCard, testDeck.transform.position, testCard.transform.rotation);
			testDeck.GetComponent<Deck> ().add (newCard);
			testDeck.GetComponent<Deck> ().register (newCard);
			*/
			testDeck.GetComponent<Deck> ().createCard ();
		}
	}
}
