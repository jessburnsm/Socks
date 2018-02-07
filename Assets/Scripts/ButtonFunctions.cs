using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {
	public void Start(){
		Screen.fullScreen = false;
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Quit(){
		Application.Quit ();
	}

	public void MainMenu(){
		SceneManager.LoadScene ("StartMenu");
	}

	public void StartGame(){
		SceneManager.LoadScene ("MainGame");
	}
}
