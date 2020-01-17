using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinsScreenControl : MonoBehaviour {

	public Text coinsCollected, BlueText, RedText;
	public GameObject tick1, tick2, tick3;
	public static bool Check1, Check2, Check3;
	[SerializeField]
	public int coins;
	[SerializeField]
	public static bool CurrentCheck;

	public int CharacterID;



	public Button GreenButton, BlueButton, RedButton;

	public bool BlueLock, RedLock;

	// Use this for initialization
	void Start () {
		coins = PlayerPrefsManager.GetPlayerCoins ();
		coinsCollected.text = "" + coins;
		CharacterID = PlayerPrefsManager.GetDefaultCharacter ();

		DefaultCharacterCheck ();
		CheckTicks ();
		BlueLock = PlayerPrefsManager.GetBlueLock();
		RedLock = PlayerPrefsManager.GetRedLock();


//		SelectChecker ();

		SetInteractableButton ();
		CheckLocks ();

	}
	
	// Update is called once per frame
	void Update () {
		coins = PlayerPrefsManager.GetPlayerCoins ();
		coinsCollected.text = "" + coins;

		BlueLock = PlayerPrefsManager.GetBlueLock();
		RedLock = PlayerPrefsManager.GetRedLock();


		CharacterID = PlayerPrefsManager.GetDefaultCharacter ();
		DefaultCharacterCheck ();
		CheckTicks ();
//		SelectChecker ();

		SetInteractableButton ();
		CheckLocks ();


	}

	public void onPressGreenButton()
	{
			Check2 = false;
			Check3 = false;
			Check1 = true;
		PlayerPrefsManager.SetDefaultCharacter (1);
		
	}
	public void onPressBlueButton()
	{
		CheckLocks ();
		if (BlueLock == true) {
		Check1 = false;
		Check3 = false;
		Check2 = true;
		PlayerPrefsManager.SetDefaultCharacter (2);
		} 
		else
		{
			PlayerPrefsManager.SetPlayerCoins (coins - 500);
			PlayerPrefsManager.SetBlueLock(true);
		}
	}

	public void onPressRedButton()
	{
		CheckLocks ();
		if (RedLock == true) {
		Check1 = false;
		Check2 = false;
		Check3 = true;
		PlayerPrefsManager.SetDefaultCharacter (3);
		} 
		else
		{
			PlayerPrefsManager.SetPlayerCoins (coins - 1000);
			PlayerPrefsManager.SetRedLock(true);
		}
	}

	public void onPressBackButton()
	{
		SceneManager.LoadScene ("Start_Screen");
	}

//	private void SelectChecker()
//	{
//		if (Check1 == true) {
//			tick1.SetActive (true);
//			tick2.SetActive (false);
//			tick3.SetActive (false);
//			Check2 = false;
//			Check3 = false;
//		}
//		if (Check2 == true) {
//			tick2.SetActive (true);
//			tick1.SetActive (false);
//			tick3.SetActive (false);
//			Check1 = false;
//			Check3 = false;
//		}
//
//		if (Check3 == true) {
//			tick3.SetActive (true);
//			tick1.SetActive (false);
//			tick2.SetActive (false);
//			Check1 = false;
//			Check2 = false;
//		}
//	}

	private void DefaultCharacterCheck()
	{
		if (CharacterID == 1) 
		{
			Check1 = true;
			Check2 = false;
			Check3 = false;
		}
		if (CharacterID == 2) 
		{
			Check2 = true;
			Check1 = false;
			Check3 = false;
		}
		if (CharacterID == 3) 
		{
			Check3 = true;
			Check1 = false;
			Check2 = false;
		}
	}

	private void CheckTicks()
	{
		if (CharacterID == 1) 
		{
			tick1.SetActive (true);
			tick2.SetActive (false);
			tick3.SetActive (false);
		}

		if (CharacterID == 2) 
		{
			tick2.SetActive (true);
			tick1.SetActive (false);
			tick3.SetActive (false);
		}

		if (CharacterID == 3) 
		{
			tick3.SetActive (true);
			tick1.SetActive (false);
			tick2.SetActive (false);
		}
	}

	private void CheckLocks()
	{
		if (BlueLock == true) {
			BlueText.text = "Blue";
			BlueButton.interactable = true;
		}
		else 
		{
			BlueText.text = "Blue\n500";
		}
		if (RedLock == true) {
			RedText.text = "Red";
			RedButton.interactable = true;
		} 
		else 
		{
			RedText.text = "Red\n1000";
		}
	}

	private void SetInteractableButton()
	{
		GreenButton.interactable = true;
		BlueButton.interactable = false;
		RedButton.interactable = false;

		if (coins >= 500) {
			BlueButton.interactable = true;
		} else
		{
			BlueButton.interactable = false;
		}

		if (coins >= 1000) {
			RedButton.interactable = true;
		} else {
			RedButton.interactable = false;
		}
	}
}
