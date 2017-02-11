using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

	private PlayerController player;
	private Rigidbody2D rb2d;
	public Vector2 velocity;

	//private int level;

	void Start ()
	{ 
		int level = GameObject.Find ("Player").GetComponent<PlayerController> ().getLevel ();
		velocity.y = velocity.y - level;
		rb2d = GetComponent<Rigidbody2D> ();
		Debug.Log (velocity.y);
	}
	// Update is called once per frame
	void Update ()
	{
		rb2d.MovePosition (rb2d.position + (velocity) * Time.fixedDeltaTime); 
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag ("Ground")) { // check for Pickup
			Destroy (gameObject); // called every time we touch a 2D trigger collider
		}
	}
	// called when player first touches 2D trigger collider
}
