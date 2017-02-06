using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private Rigidbody2D body;
	private Vector2 move; 

	public SnapCam cam;
	public float runSpeed;
	public float jumpHeight = 10;
	public bool grounded;

	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.D)) { move.x = 1; } //move right
		else if (Input.GetKey(KeyCode.A)) { move.x = -1; } //move left
		else { move.x = 0; } //never walk again

		if (Input.GetKeyDown(KeyCode.Mouse0) && grounded) {
			body.velocity = new Vector2(body.velocity.x, jumpHeight);
			grounded = false;
		}

		body.velocity = new Vector2(move.x * runSpeed, body.velocity.y);
	}

	void OnCollisionEnter2D (Collision2D collision) {
		//if (collision.transform.name == "Ground") {
			grounded = true;
		//}
		
		//print(collision.transform.position.y - transform.position.y); 
		//print(collision.contacts[0].point.y - transform.position.y);
	}

	void OnTriggerEnter2D (Collider2D collision) {
		switch (collision.transform.name) {
			case "P2": cam.snapCamera(2); break;
			case "P3": cam.snapCamera(3); break;
			case "P4": cam.snapCamera(4); break;
			case "BallDrop": 
			
				break;
		}
	}
}
