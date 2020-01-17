using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPickUp : MonoBehaviour {

	public int CoinsToAdd;
	public AudioSource audiocoins;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
		CoinsManager.AddCoins (CoinsToAdd);
		audiocoins.Play ();
		Destroy (gameObject);
	}
}
