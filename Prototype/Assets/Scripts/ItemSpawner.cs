using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

	// Use this for initialization

	public string tag;

	public Transform position;

	public Quaternion rotation;


	private ObjectPooler objectPooler;



	void Start(){
		objectPooler = ObjectPooler.Instance;
	}



	/*public float upForce = 1f;
	 * public float side force = .1f
	 * 
	 * start(){
	 * float XForce = Random.Range(-sideForce, sideForce);
	 * 

	*/

	void FixedUpdate(){
		ObjectPooler.Instance.SpawnFromPool ("Tomato", transform.position, Quaternion.identity);
	}
}
