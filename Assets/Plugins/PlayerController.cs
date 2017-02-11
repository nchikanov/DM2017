using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour {

	//private JS1 jsScript;

	public float speed; 
	private static int score = 0; 
	private int curr_score; 
	public Text countText;
	public Text timeText; 
	public Text levelText; 
	private float timepassed;
	private int LEVEL_SEC = 20; 
	static int lvl = 0;  
	private int SCORE2PASS; 

	/*void Awake(){
		jsScript = this.GetComponent<JS1>();
	}*/

	void Start(){
		lvl++; 
		levelText.text = "Level: " + lvl.ToString (); 
		timepassed = 30;
		SCORE2PASS = lvl * 150; 
		setText (); 
	}

	void reStart(){
		lvl = 0; 
		score = 0; 
	}

	public int getLevel(){
		return lvl; 
	}

	void Update()
	{ 
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		Vector3 move = new Vector3(moveHorizontal, 0, 0);
		transform.position += move * speed * Time.deltaTime;

		timepassed = LEVEL_SEC - (Mathf.RoundToInt(Time.timeSinceLevelLoad));
		timeText.text = "Seconds left: " + timepassed.ToString ();

		if ((timepassed == 0)) {
			//DO SOMETHING CRAZY 
			//Application.Quit (); 
			if ((score >= SCORE2PASS))
				Application.LoadLevel (3); //LOADING PAGE
			else{
				Application.LoadLevel (4); //DIE
				reStart(); 
			}
		}

	}
		

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("PickUp1") || other.CompareTag("PickUp2"))
		{
			if (other.CompareTag("PickUp1")) {
				score += 10;
			} else if (other.CompareTag ("PickUp2")) {
				score += 15;
			} else
				score += 0;

			//timepassed = Time.realtimeSinceStartup;

			Destroy (other.gameObject);
			setText ();
		}
	} // called when player first touches 2D trigger collider 

	void setText() {
		countText.text = "Score: " + score.ToString () + " / " + SCORE2PASS.ToString(); 
		//timeText.text = "Seconds left: " + timepassed.ToString (); 

	}
}
