using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Coin")) {
			//	StartCoroutine(DieAndRespawn()); 
			Destroy (other.gameObject);
		}
		if (other.gameObject.CompareTag ("Player")) {
			//	StartCoroutine(DieAndRespawn()); 
			other.gameObject.SetActive(false);
			Time.timeScale = 0;
		}
	}
}
