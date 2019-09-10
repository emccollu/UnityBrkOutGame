using UnityEngine;
using System.Collections;

public class Paddle: MonoBehaviour {
	public float speed = 50;

	void FixedUpdate () {
		float h = Input.GetAxisRaw("Horizontal");
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
	}
}
