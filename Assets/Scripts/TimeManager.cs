using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {
	public Text timeText;
	public float totalTime;
	private float timeLeft;

	// Use this for initialization
	void Start () {
		GameState.StartGame ();
		timeLeft = totalTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeLeft -= Time.deltaTime;
		timeText.text = ((int)timeLeft).ToString ();

		if (timeLeft <= totalTime / 3) {
			GameState.MoveDog ();
		}

		if (timeLeft <= 0) {
			enabled = false;
			GameState.EndGame ();
		}
	}
}
