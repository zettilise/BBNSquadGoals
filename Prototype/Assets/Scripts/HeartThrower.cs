using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartThrower : MonoBehaviour {


	public GameObject itemToThrow;


	public float chanceNumber;

	private Vector3 OriginalPos;
	public GameObject Thrower;
	public Vector3 force;
	public float number;
	// Use this for initialization
	void Start () {

		OriginalPos = itemToThrow.transform.position;

	}

	// Update is called once per frame
	void Update () {
		
		OriginalPos = Thrower.transform.position;
		//cubePosition = cube.transform;
		if (itemToThrow.activeSelf) {//Random.Range(0,chanceNumber) == 0  && 
			
			itemToThrow.transform.position = itemToThrow.transform.position + force;

		} else {
			number = Random.Range (0, 1000);

			if (number <= chanceNumber) {//if (Random.Range(0,chanceNumber) == 0){
			itemToThrow.transform.position = OriginalPos;
			itemToThrow.SetActive (true);
			itemToThrow.transform.position = itemToThrow.transform.position + force;
			}
		}
			

	}
		
}
