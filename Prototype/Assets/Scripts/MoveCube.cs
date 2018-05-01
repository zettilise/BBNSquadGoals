using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

	public float moveSpeed = 3f;
	public float jumpHeight;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);
		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);
		transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Jump")* jumpHeight);

	}
}
