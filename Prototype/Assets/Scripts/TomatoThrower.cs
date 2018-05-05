using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoThrower : MonoBehaviour {


	public GameObject itemToThrow;

	public Transform cubePosition;

	public GameObject cube;

	// Use this for initialization
	void Start () {
		cube = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		cubePosition = cube.transform;

	}
	
}
