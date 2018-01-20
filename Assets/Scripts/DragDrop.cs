using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Defines drag and drop behavior on Rigid Bodies
// Heavily modified from http://wiki.unity3d.com/index.php?title=DragObject
public class DragDrop : MonoBehaviour {
	private Camera cam;
	private Rigidbody2D myRigidbody;
	private Transform myTransform;
	private bool canMove = false;
	private bool freezeRotationSetting;
 
	void Start () 
	{
	    myRigidbody = GetComponent<Rigidbody2D>();
	    myTransform = transform;
	    cam = Camera.main;
	}
 
	void OnMouseDown () 
	{
	    canMove = true;
	    myRigidbody.freezeRotation = true;
	}
 
	void OnMouseUp () 
	{
	    canMove = false;
		myRigidbody.freezeRotation = false;
		myRigidbody.velocity = new Vector2 (Input.GetAxis ("Mouse X") * 5f, myRigidbody.velocity.y);
	}
 
	void FixedUpdate () 
	{
	    if (!canMove)
			return;
 
	    myRigidbody.velocity = Vector2.zero;
	    myRigidbody.angularVelocity = 0;
 
		Vector2 pos = myTransform.position;
	    myTransform.position = pos;
 
	    Vector2 mousePos = Input.mousePosition;
	    Vector2 move = cam.ScreenToWorldPoint(new Vector2(mousePos.x, mousePos.y)) - myTransform.position;
 
	    myRigidbody.MovePosition(myRigidbody.position + move);
	}
}
