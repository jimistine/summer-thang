using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed = 10f;
	private Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");

		//jump
		Input.GetKeyDown("W");

		Vector2 movement = new Vector2 (moveHorizontal, 0f);

		rb2d.AddForce (movement * Speed);

		//Sends Impulse into Puck
		//Makes subtle sound effect when moving
		//Hold left Shift to slow speed but increase power

	}
}
