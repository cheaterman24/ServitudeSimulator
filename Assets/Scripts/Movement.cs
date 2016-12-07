using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float Speed, jumpPower;
	Vector3 movement;
	public bool grounded;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		movement = Vector3.zero;
	}

	void CheckJump()
	{
		if (grounded && Input.GetButton ("Jump")) {
			rb.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			grounded = false;
		}
		movement.y = rb.velocity.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		if (rb.velocity.y == 0) {
//			grounded = true;
//		} else
//			grounded = false;

		movement.x = Input.GetAxis ("Horizontal") * Speed;

		CheckJump();

		rb.velocity = movement;
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.collider.tag == "TerrainHolder") {
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.collider.tag == "TerrainHolder") {
			grounded = false;
		}
	}
}
