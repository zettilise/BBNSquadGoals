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


	void FixedUpdate(){
		ObjectPooler.Instance.SpawnFromPool ("Tomato", transform.position, Quaternion.identity);

	}
}
