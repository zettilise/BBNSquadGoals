using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinThrower : MonoBehaviour {


	public GameObject itemToThrow;

	//public Transform cubePosition;
	//public GameObject cube;
	public float chanceNumber;
	private float timeCount = 0;

	private Vector3 OriginalPos;
	public GameObject Thrower;
	public Vector3 force;
	//private Rigidbody rb;
	public float number;

	// Use this for initialization
	void Start () {

		OriginalPos = itemToThrow.transform.position;
		//itemToThrow.SetActive(true);
		//rb.AddForce (transform.forward * 200,ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {
		
		OriginalPos = Thrower.transform.position;
		//cubePosition = cube.transform;
		timeCount++;

		if (itemToThrow.activeSelf) {//Random.Range(0,chanceNumber) == 0  && 
			
			itemToThrow.transform.position = itemToThrow.transform.position + force;

		} else {
			//System.Threading.Thread.Sleep(Random.Range(1000, 5000));
			number = Random.Range (0, 100);

			if (number <= chanceNumber) {
				itemToThrow.transform.position = OriginalPos;
				itemToThrow.SetActive (true);
				itemToThrow.transform.position = itemToThrow.transform.position + force;
			}
		}


	}

	/*
	void FixedUpdate(){
		timeCount++;
		if (timeCount % cycleAmount == 0) {
			increaseLikelihood ();
		}


	}
	void increaseLikelihood(){
		if (chanceNumber != 1) {
			chanceNumber--;
		}
	}
*/

}
