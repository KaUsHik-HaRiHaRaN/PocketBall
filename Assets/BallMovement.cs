using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public int jumpHeight = 20;
	private bool isFalling = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.acceleration.x;
		float moveVertical = Input.acceleration.z;  
		Vector3 movement = new Vector3 (moveHorizontal, 0, -moveVertical);
		rb.AddForce (movement * speed);
		if (Input.GetKeyDown (KeyCode.Space) && isFalling == false) {
			rb.velocity = new Vector3(moveHorizontal, jumpHeight, 0);
			isFalling = true;
		}
	}

	void OnCollisionStay() {

		isFalling = false;

	}

	public void Jump() {
		if (isFalling == false) {
			float moveHorizontal = Input.acceleration.x;
			float moveVertical = Input.acceleration.z; 
			rb.velocity = new Vector3 (moveHorizontal, jumpHeight, -moveVertical);
			isFalling = true;
		}
	}
}
