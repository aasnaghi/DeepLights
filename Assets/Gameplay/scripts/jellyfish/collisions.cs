﻿using UnityEngine;
using System.Collections;

public class collisions : MonoBehaviour {

	Rigidbody2D rigidBody;
	GameManager gameManager;
	//Animator anWarning;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> () as Rigidbody2D;
		gameManager = GameObject.Find ("Controller").GetComponent<GameManager> () as GameManager;
		//anWarning = (GameObject.FindGameObjectWithTag ("warning")).GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "sphere") {
						//Destroy (other.gameObject);
						gameManager.increaseLife (20);
						gameManager.showUpdatedScore ();

				} 
		//TODO: manage other collision
		else if (other.gameObject.tag == "Pincers") {
						gameManager.decreaseLife (20);
						//warning();
				} else if (other.gameObject.tag == "Predator") {
						if (other.GetType () == typeof(BoxCollider2D)) {
								gameManager.decreaseLife (20);
								//warning();
						}

				} else if (other.gameObject.tag == "assassinAlga") {
						gameManager.decreaseLife (20);
						//warning();
				} else if (other.gameObject.tag == "melma") {
						gameManager.decreaseLife(20);		
		}
		else if (other.gameObject.tag == "nextLevel") {
			gameManager.changeLevel();
			//warning();
		}

	}




}
