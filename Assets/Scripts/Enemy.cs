using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	public GameObject gameOverScreen;
	public GameObject pauseButton;
	public GameControllerScript gcs;
	public Text gameOverScore;
	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		transform.position = new Vector3 (transform.localPosition.x, transform.localPosition.y, 10);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (transform.localPosition.x, transform.localPosition.y, 10);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.gameObject.SetActive (false);
			ProcessGameOver ();
		}
	}

	public void ProcessGameOver()
	{
		gameOverScreen.SetActive(true);
		pauseButton.SetActive (false);

		int bestScore = PlayerPrefs.GetInt ("LocalScore");
		if (bestScore < gcs.score) {
			PlayerPrefs.SetInt ("LocalScore", gcs.score);
			gameOverScore.text = "New Highscore! " + gcs.score;
		} 
		else
		{
			gameOverScore.text = "Score: " + gcs.score;
		}

		gcs.PauseUnPauseGame ();	
	}
}
