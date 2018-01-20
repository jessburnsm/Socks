using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://answers.unity.com/questions/799656/how-to-keep-an-object-within-the-camera-view.html
public class ContrainInCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		 //Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
         //pos.x = Mathf.Clamp01(pos.x);
         //pos.y = Mathf.Clamp01(pos.y);
         //transform.position = Camera.main.ViewportToWorldPoint(pos);
	}
}
