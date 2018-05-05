using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCube : MonoBehaviour {

	public float moveSpeed = 3f;
	public float jumpHeight;

	private Vector3 startPos;

	public Text deathText;
	public int deaths;

	public Text lives;


	public Button ReplayButton;

	public GameObject ReplayActive;

	// Use this for initialization
	void Start ()
	{
		//ReplayActive = GameObject.FindGameObjectWithTag ("Replay");
		lives.enabled = true;
		deaths = 3;
		deathText.enabled = false;
		startPos = transform.position;
		SetLivesText ();

		ReplayButton.onClick.AddListener (ResetStats); // YOYOYOY
	}

	void SetLivesText()
	{
		lives.text = "Lives left: " + deaths;
	}

	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);
		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);
		transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Jump")* jumpHeight);

		

		if (transform.position.y < .6f) 
		{
			
			if (deaths != 0) 
			{
				transform.position = startPos;
				deaths--;
				SetLivesText ();
			} 
			else 
			{
				deathText.enabled = true;
				lives.text = "X_X";
				transform.position = startPos;
				ReplayActive.SetActive (true); // YOYOY
			}

		}

	}

	void ResetStats(){
		lives.enabled = true;
		deaths = 3;
		deathText.enabled = false;
		startPos = transform.position;
		SetLivesText ();
		ReplayActive.SetActive (false);
		Debug.Log ("resetted stats");

	}
}
