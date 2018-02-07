using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockGenerator : MonoBehaviour {
	public GameObject sockPrefab;
	public Sprite[] sprites = new Sprite[4];
	private bool socksDropping = false;

	// Use this for initialization
	void Start () {
		StartCoroutine (UnloadSocks (50));
	}

	void Update(){
		if (!socksDropping && GameState.GetNumberOfSocks () < 25) {
			StartCoroutine (UnloadSocks (25));
		}
	}

	IEnumerator UnloadSocks(int count)
	{
		socksDropping = true;
		Vector3 spawnPosition = new Vector3 ();
		spawnPosition.y = transform.position.y;
		for (int i = 0; i < count; i++) {
			GameState.AddSock ();
			spawnPosition.x = Random.Range(transform.position.x - 3, transform.position.x + 3);
			GameObject obj = Instantiate (sockPrefab, spawnPosition, Quaternion.identity);
			int color = (int)Random.Range (0, sprites.Length);
			obj.GetComponent<SpriteRenderer>().sprite = sprites[color];
			obj.GetComponent<Sock> ().SetSockColor (color);
			yield return new WaitForSeconds(.25f);
		}
		socksDropping = false;
	}
}
