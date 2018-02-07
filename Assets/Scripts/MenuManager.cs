using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public Animator endMenu;
	
	// Update is called once per frame
	void Update () {
		if (GameState.IsGameOver ()) {
			endMenu.SetBool ("isOpen", true);
		}
	}
}
