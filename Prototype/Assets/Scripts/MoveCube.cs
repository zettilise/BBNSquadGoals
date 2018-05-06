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

	public float score;

	public GameObject TomatoThrower;
	public GameObject LivesThrower;
	public GameObject PinThrower;
	public GameObject PinThrower2;

	public GameObject ScoreText;


	public Text HighScore;
	public Text CurrScore;
	private int highScore;

	public AudioSource Pin;
	public AudioSource Heart;
	public AudioSource Tomato;
	public AudioSource dedFall;
	public AudioSource completeDeath;


	// Use this for initialization
	void Start ()
	{
		highScore = 0;

		lives.enabled = true;
		deaths = 3;
		deathText.enabled = false;
		startPos = transform.position;
		SetLivesText ();
		ReplayButton.onClick.AddListener (ResetStats); // YOYOYOY
		SetScoreText();
	}

	void SetScoreText()
	{
		HighScore.text = "High Score: " + highScore;
		CurrScore.text = "Score: " + score;
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
				dedFall.Play ();
				transform.position = startPos;
				deaths--;
				SetLivesText ();
			} 
			else 
			{
				SetScoreText ();

				deathText.enabled = true;
				lives.text = "X_X";
				transform.position = startPos;

				ScoreText.SetActive(true);
				ScoreText.GetComponent<Text>().text = "Score: " + score;
		
				ReplayActive.SetActive (true); // YOYOY
				LivesThrower.SetActive(false);
				TomatoThrower.SetActive(false);
				PinThrower.SetActive(false);
				PinThrower2.SetActive (false);
				completeDeath.Play ();
			}

		}
		SetScoreText ();
	}

	void ResetStats(){

		if ((int)score > highScore)
			highScore = (int)score;

		lives.enabled = true;
		deaths = 3;
		deathText.enabled = false;
		startPos = transform.position;
		SetLivesText ();
		ReplayActive.SetActive (false);

		score = 0;
		LivesThrower.SetActive(false);
		PinThrower.SetActive(false);
		PinThrower2.SetActive (false);
		TomatoThrower.SetActive(false);


	
		SetScoreText ();



		Debug.Log ("resetted stats");

	}

	void OnCollisionEnter(Collision collision){
		Debug.Log ("have collided with " + collision.gameObject.tag);

		if (collision.gameObject.tag == "Tomato") {

		}
	}

	void OnTriggerEnter (Collider other){
		Debug.Log("trigger of " + other.gameObject.tag);

		if (other.gameObject.tag == "Pin") {
			score += 5;
			other.gameObject.SetActive (false);
			Pin.Play ();
			SetScoreText ();
		}

		if (other.gameObject.tag == "Heart") {
			deaths++;
			SetLivesText();
			other.gameObject.SetActive (false);
			Heart.Play ();
		}

		if (other.gameObject.tag == "Tomato") {
			Tomato.Play ();
		}
	}
		
}
