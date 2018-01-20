using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour {
	public GameObject neutralFace;
	public GameObject smileFace;
	public GameObject frownFace;

	// Use this for initialization
	void Start () {
		SetNeutral ();
	}
	
	public void SetNeutral(){
		neutralFace.SetActive (true);
		smileFace.SetActive (false);
		frownFace.SetActive (false);
	}

	public void SetSmile(){
		neutralFace.SetActive (false);
		smileFace.SetActive (true);
		frownFace.SetActive (false);
	}

	public void SetFrown(){
		neutralFace.SetActive (false);
		smileFace.SetActive (false);
		frownFace.SetActive (true);
	}
}
