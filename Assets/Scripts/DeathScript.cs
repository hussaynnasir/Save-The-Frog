using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

	public GameObject gameOverScreen;
	public GameObject pauseButton;
	public GameObject RocketB;
	public GameControllerScript gcs;
	public Text gameOverScore;

	public static bool RemovePlayer;

    Ads ads;

    private void Start()
    {
        ads = GetComponent<Ads>();
		RemovePlayer = false;
    }

	private void Update()
	{
		if (JumpCheck.DeathTrigger == true) 
		{
			ProcessGameOver();
		}
	}

//	private void Update()
//	{
//		if (gameOverScreen.activeInHierarchy) {
//			RemovePlayer = true;
//		} else 
//		{
//			RemovePlayer = false;
//		}
//
//	}
    /**
	 * Called when the player touches this object and thereby losing the game.
	 * Activates the game over window and 'pauses' the game.
	 */
    void OnTriggerEnter2D(Collider2D other) {
//        ads.ShowAd();
        // Called when player loses:
		if (other.gameObject.CompareTag("Player"))
		{
			ProcessGameOver ();
		}
		if (other.gameObject.CompareTag ("Enemy")) 
		{
			RemovePlayer = true;
		}
    }

	public void ProcessGameOver()
	{
			gameOverScreen.SetActive(true);
			pauseButton.SetActive (false);
			RocketB.SetActive (false);

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
			Time.timeScale = 0;
	}
}
