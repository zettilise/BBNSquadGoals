using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {


	[System.Serializable]
	public class Pool
	{
		public string tag;
		public GameObject prefab;
		public int size;

	}



	public static ObjectPooler Instance;

	private void Awake(){
		Instance = this;
	}
		

	public List<Pool> pools;
	 
	public Dictionary <string, Queue<GameObject>> poolDictionary;
	// Use this for initialization

	void Start () {
		poolDictionary = new Dictionary<string, Queue<GameObject>>();


		foreach (Pool pool in pools) { // for each poll we want to create in pools
			Queue<GameObject> objectPool = new Queue<GameObject> (); //create a queue full of objects

			for (int i = 0; i < pool.size; i++) { // add all the objects into the queue
				GameObject obj = Instantiate (pool.prefab);
				obj.SetActive (false);
				objectPool.Enqueue (obj);
			}

			//add pool into that dictionary
			poolDictionary.Add(pool.tag, objectPool);

		}
	}


	public GameObject SpawnFromPool (string tag, Vector3 position, Quaternion rotation){

		if (!poolDictionary.ContainsKey(tag)){
			Debug.Log("Pool with tag " + tag + " doesn't exist.");
			return null;
		}

			GameObject objectToSpawn= poolDictionary [tag].Dequeue ();
			objectToSpawn.SetActive (true);
			objectToSpawn.transform.position = position;
			objectToSpawn.transform.rotation = rotation;

			poolDictionary [tag].Enqueue (objectToSpawn);
		return objectToSpawn;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
