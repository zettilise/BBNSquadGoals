﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoThrower : MonoBehaviour {


	public GameObject itemToThrow;

	public GameObject cube;

	private float timeCount = 0;

	private Vector3 OriginalPos;
	public GameObject Thrower;
	public Vector3 force;


	void Start () {
		OriginalPos = itemToThrow.transform.position;
	}
		
	void Update () {
		OriginalPos = Thrower.transform.position;
		timeCount++;
		if (itemToThrow.activeSelf) {
			itemToThrow.transform.position = itemToThrow.transform.position + force;

			MoveCube script = cube.GetComponent<MoveCube> ();
			script.score += .5f;

		} else {
			itemToThrow.transform.position = OriginalPos;
			itemToThrow.SetActive (true);
			itemToThrow.transform.position = itemToThrow.transform.position + force;


		}

		if (timeCount % 500 == 0) { // every ten seconds

			if (force.x > -.5) {// as long as force isn't as big as -.5
				force.x -= 0.05f;
			}

		}

	}
}
