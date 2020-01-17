using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour {

	private bool Jumping;
	private Rigidbody2D rb2d;
	private Animator checker;
	float extraGravityDown = 1.01f;
	[SerializeField]
	private GameControllerScript gm;
	AudioSource playerAS;
	public float thrust;

//	public AudioClip rocketSound;

	public static bool DeathTrigger;

	public AudioClip CoinCollect;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		checker = GetComponent<Animator> ();
		playerAS = GetComponent<AudioSource> ();
		checker.SetBool ("Jumping", Jumping);
		DeathTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {

		DeathTrigger = false;

		checker.SetBool ("Jumping", Jumping);
		if (rb2d.velocity.y > 0.1)
		{
			Jumping = true;
		}
		else
		{
			Jumping = false;
		}

		ExtraGravityDown ();
	}

	void FixedUpdate()
	{
		
	}

//	public IEnumerator fireFly()
//	{
//		playerAS.clip = rocketSound;
	//	GameControllerScript.Fire = true;
//		if (GameControllerScript.Fire = true) 
//		{
//			AddVerticalForce ();
//			playerAS.Play ();
//		}
//		yield return new WaitForSeconds (3);
//		GameControllerScript.Fire = false;
//	}

	public void AddVerticalForce()
	{
		rb2d.velocity = new Vector3(0, 40, 0);
	}

//		if (DeathScript.RemovePlayer = true) {
//			gameObject.SetActive (false);
//		} 
//		else
//		{
//			gameObject.SetActive (true);
//		}



	void ExtraGravityDown() {
		if (rb2d.velocity.y < 0) {
			rb2d.velocity = new Vector2 (rb2d.velocity.x, rb2d.velocity.y * extraGravityDown);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Coin")) {
			//	StartCoroutine(DieAndRespawn()); 
			Destroy (other.gameObject);
			playerAS.clip = CoinCollect;
			playerAS.Play ();
			gm.coins += 1;
		}
		if (other.gameObject.CompareTag ("Enemy")) {
			//	StartCoroutine(DieAndRespawn()); 
			DeathTrigger=true;
			gameObject.SetActive(false);
		}
	}

}
