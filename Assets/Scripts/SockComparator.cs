using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockComparator : MonoBehaviour {
	public GameObject sockUnit;
	private FaceManager faceManager;
	private List<Sock> socks = new List<Sock> ();

	void Start(){
		faceManager = sockUnit.GetComponent<FaceManager> ();
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.CompareTag ("Sock")) {
			socks.Add (obj.gameObject.GetComponent<Sock> ());
			CompareSocks ();
		} 
		else {
			Dispose (obj.gameObject.GetComponent<Rigidbody2D> ());
		}
	}

	void OnTriggerExit2D(Collider2D sock){
		socks.Remove (sock.gameObject.GetComponent<Sock> ());
	}

	void CompareSocks(){
		// pull first and second sock from list
		if (socks.Count >= 2) {
			if (socks [0].GetSockColor () == socks [1].GetSockColor ()) {
				Debug.Log ("Socks Matched");
				faceManager.SetSmile ();
				GameState.UpdateScore ();
				DestroySocks(socks [0], socks [1]);
			} 
			else {
				faceManager.SetFrown ();
				DisposeSocks ();
			}
		}
	}

	private void DestroySocks(Sock sock1, Sock sock2){
		socks.Remove (sock1);
		socks.Remove (sock2);

		Destroy (sock1.gameObject);
		Destroy (sock2.gameObject);
	}

	private void DisposeSocks(){
		foreach (Sock sock in socks) {
			Rigidbody2D rb2d = sock.gameObject.GetComponent<Rigidbody2D> ();
			rb2d.AddForce (new Vector2 (-100, 1200));
		}
	}

	private void Dispose(Rigidbody2D rb2d){
		rb2d.AddForce (new Vector2 (-100, 1200));
	}
}
