using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;

    public float speed;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		//Called before rendering a frame
	}

	void FixedUpdate()
	{
		//Called just before any physics calculations are done
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce(movement * speed);
	}
}
