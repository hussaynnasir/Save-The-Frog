using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string Player_Count = "player_count";

    const string Sound_Mode = "sound_mode";

    const string Player_Title = "player_title";


    const string Player_Coins = "player_coins";

    const string Collected_stars = "collected_stars";

    const string Currency_1 = "currency_1";

    const string Player_Highscore = "player_highscore";

    const string Current_Date = "current_date";

    const string Daily_Reward_Count = "daily_reward_count";

	const string BlueLock = "blue_lock";

	const string RedLock = "red_lock";

	const string Default_Character = "default_character";

    public static void SetDailRewardCount(int value){
        PlayerPrefs.SetInt(Daily_Reward_Count,value);
    }

    public static int GetDailyRewardsCount(){
        return PlayerPrefs.GetInt(Daily_Reward_Count);
    }

    public static void SetCurrentDate(System.DateTime dateTime){
        PlayerPrefs.SetString(Current_Date, dateTime.ToString());
    }

    public static string GetCurrentDate(){
        return PlayerPrefs.GetString(Current_Date);
    }

    public static void SetPlayerHighScore(int value){

        if(value >= PlayerPrefs.GetInt(Player_Highscore)){
            PlayerPrefs.SetInt(Player_Highscore, value);
        }
        else {
            Debug.Log(value.ToString() + " is less than " + PlayerPrefs.GetInt(Player_Highscore).ToString());
        }

    }

    public static int GetPlayerHighScore(){
        return PlayerPrefs.GetInt(Player_Highscore);
    }

    public static void SetPlayerCoins(int value){
        PlayerPrefs.SetInt(Player_Coins, value);
    }


    public static int GetPlayerCoins(){
        return PlayerPrefs.GetInt(Player_Coins);
    }

    public static void SetCollectedStars(int value)
    {
        PlayerPrefs.SetInt(Collected_stars, value);
    }


    public static int GetCollectedStars()
    {
        return PlayerPrefs.GetInt(Collected_stars);
    }


    public static void SetCurrency_One(int value)
    {
        PlayerPrefs.SetInt(Currency_1, value);
    }


    public static int GetCurrency_One()
    {
        return PlayerPrefs.GetInt(Currency_1);
    }

    public static void SetPlayerCount(int value){
        PlayerPrefs.SetInt(Player_Count, value);
    }
    public static int GetPlayerCount()
    {
        return PlayerPrefs.GetInt(Player_Count);
    }

    public static void SetSoundMode(bool value)
    {
        PlayerPrefs.SetInt(Sound_Mode, value ? 1 : 0);
    }
    public static bool GetSoundMode()
    {
        if(PlayerPrefs.GetInt(Sound_Mode) == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void SetPlayerTitle(string value)
    {
        PlayerPrefs.SetString(Player_Title, value);
    }
    public static string GetPlayerTitle()
    {
        return PlayerPrefs.GetString(Player_Title);
    }

	public static void SetBlueLock(bool value)
	{
		PlayerPrefs.SetInt(BlueLock, value ? 1 : 0);
	}

	public static bool GetBlueLock()
	{
		if(PlayerPrefs.GetInt(BlueLock) == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public static void SetRedLock(bool value)
	{
		PlayerPrefs.SetInt(RedLock, value ? 1 : 0);
	}

	public static bool GetRedLock()
	{
		if(PlayerPrefs.GetInt(RedLock) == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
	}


	public static void SetDefaultCharacter(int value){
		PlayerPrefs.SetInt(Default_Character,value);
	}

	public static int GetDefaultCharacter(){
		return PlayerPrefs.GetInt(Default_Character);
	}

}
