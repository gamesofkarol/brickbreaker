using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Rigidbody2D ball;
	public float ballSpeed;

	public Rigidbody2D player;
	public float playerSpeed;

	private float direction;

	void Start () {
		ball.AddForce (new Vector2 (1, 1) * ballSpeed);
	}
	

	void Update () {
		direction = Input.GetAxisRaw ("Horizontal");
		player.velocity = new Vector2 (direction, 0) * playerSpeed;
	}
}
