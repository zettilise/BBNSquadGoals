using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GUIScript.GUIState state;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clicked(){
        GameObject.Find("Canvas").GetComponent<GUIScript>().switchScreen(state);
    }
}
