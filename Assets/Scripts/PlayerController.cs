using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Fields
	[SerializeField] float speed = 1.0f; // private
	private Rigidbody m_rb;

	// Start is called before the first frame update
	// Methods
	void Start()
	{
		m_rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		Movements();
	}

	private void Movements()
	{
		Vector3 input = new(
			Input.GetAxis("Horizontal"),
			0,
			Input.GetAxis("Vertical")
		);

		if (input.magnitude > 0) {
			m_rb.MovePosition(
				m_rb.position + speed * Time.fixedDeltaTime * input
			);
		}
	}
}
