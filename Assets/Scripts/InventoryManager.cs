using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {


    public static InventoryManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private int coins;

    private int collected_Stars;

    private int currency_one;

	// Use this for initialization
	void Start () {
        coins = 0;
        collected_Stars = 0;
        currency_one = 0;
        //PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddCoins(int value){
        coins = PlayerPrefsManager.GetPlayerCoins();
        coins += value;
        PlayerPrefsManager.SetPlayerCoins(coins);
        
    }


    public void DeductCoins(int value){
        coins = PlayerPrefsManager.GetPlayerCoins();
        if(value>coins){
            Debug.Log("You don't have enough coins");
        }
        else{

            coins -= value;
            PlayerPrefsManager.SetPlayerCoins(coins);
            Debug.Log("You have succesfully bought this item");
        }

    }

    public void AddCollectedStars(int value){
        collected_Stars = PlayerPrefsManager.GetCollectedStars();
        collected_Stars += value;
        PlayerPrefsManager.SetCollectedStars(collected_Stars);
    }

    public void DeductStars(int value)
    {
        collected_Stars = PlayerPrefsManager.GetCollectedStars();
        if (value > collected_Stars)
        {
            Debug.Log("You don't have enough stars");
        }
        else
        {

            collected_Stars -= value;
            PlayerPrefsManager.SetCollectedStars(collected_Stars);
            Debug.Log("You have used "+ collected_Stars + " bonus stars");
        }

    }
}
