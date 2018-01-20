using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sock : MonoBehaviour {

	private int sockColor;
	public bool rightSock;

	public void SetSockColor(int color){
		sockColor = color;
	}

	public int GetSockColor(){
		return sockColor;
	}

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().flipX = rightSock; 
	}
}
