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
		if(obj.CompareTag("Sock")){
			socks.Add (obj.gameObject.GetComponent<Sock> ());
			CompareSocks ();
		}
	}

	void OnTriggerExit2D(Collider2D sock){
		socks.Remove (sock.gameObject.GetComponent<Sock> ());
	}

	void CompareSocks(){
		Debug.Log (socks.Count);
		// pull first and second sock from list
		if (socks.Count >= 2) {
			if (socks [0].GetSockColor () == socks [1].GetSockColor ()) {
				Debug.Log ("Socks Matched");
				faceManager.SetSmile ();
				// Increase Score
				DestroySocks(socks [0], socks [1]);
			} 
			else {
				Debug.Log ("Socks Mismatched");
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
}
