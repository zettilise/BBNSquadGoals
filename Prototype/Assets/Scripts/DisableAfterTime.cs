using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour {
	public float lifeTime = 2f;
	// Use this for initialization
	void OnEnable () {
		StartCoroutine(Disabler());
	}
	private IEnumerator Disabler()
	{
		yield return new WaitForSeconds(lifeTime);
		gameObject.SetActive(false);
	}

	public void setTimeback(){
		lifeTime = 2f;
	}
}
