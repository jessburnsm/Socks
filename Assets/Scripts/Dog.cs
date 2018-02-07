using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour {
	private bool flipX = false;
	private float deltaX = - .15f;
	private SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		sprite = gameObject.GetComponent<SpriteRenderer> ();
	}

	void FixedUpdate () {
		if (GameState.GetDogIsMoving()) {
			transform.position = new Vector2 (transform.position.x + deltaX, transform.position.y);
		}	
	}

	void OnBecameInvisible() {
		GameState.StopDog();
		flipX = !flipX;
		sprite.flipX = flipX;
		deltaX = deltaX * -1;
	}
}
