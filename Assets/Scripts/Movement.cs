using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float Speed, jumpPower;
	Vector3 movement, jumpPower2;
	public bool grounded;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		movement = Vector3.zero;
	}

	void CheckJump()
	{
		if (grounded && Input.GetButtonDown ("Jump")) {
			movement.y = jumpPower;
			grounded = false;
		} else if (!grounded) {
			
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rb.velocity.y == 0) {
			grounded = true;
		} else
			grounded = false;
		
		movement.x = Input.GetAxis ("Horizontal") * Speed;
		CheckJump();
		Debug.Log (movement);
		rb.velocity = movement;
	}
}
