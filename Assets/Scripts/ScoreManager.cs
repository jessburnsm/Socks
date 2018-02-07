using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public Text scoreText;
	public Text ratingText;

	// Update is called once per frame
	void FixedUpdate () {
		scoreText.text = "SOCKS MATCHED: " + GameState.GetScore ();
		ratingText.text = "RATING: " + GameState.GetRating ();
	}
}
