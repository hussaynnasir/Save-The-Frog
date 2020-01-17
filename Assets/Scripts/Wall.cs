using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		SpriteRenderer SR;
		SR = other.GetComponent<SpriteRenderer> ();
		if (other.gameObject.CompareTag ("Enemy")) 
		{
			SR.flipX = !SR.flipX;
		}
	}
}
