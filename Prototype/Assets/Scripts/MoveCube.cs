using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

	public float moveSpeed = 3f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);


	}
}
