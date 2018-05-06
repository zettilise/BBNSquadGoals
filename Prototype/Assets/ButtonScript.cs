using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor.UI;
#endif
//using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public GUIScript.GUIState state;
	public GameObject ReplayButton;
	// Use this for initialization


	void Start () {
		//ReplayButton = GameObject.FindGameObjectWithTag ("Replay");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clicked(){
        GameObject.Find("Canvas").GetComponent<GUIScript>().switchScreen(state);
    }
}
