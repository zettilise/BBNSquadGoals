using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePin : MonoBehaviour {
	public float ZrotationSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, ZrotationSpeed*Time.deltaTime);//rotate around Z at the speed we have
		//transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
	}
}
