using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour {

    public Text notify;

    public void PurchaseItem(int value){
        InventoryManager.Instance.DeductCoins(value);
        notify.text = PlayerPrefsManager.GetPlayerCoins().ToString();
    }

    public void UseBonusStars(int value){
        InventoryManager.Instance.DeductStars(value);
        notify.text = PlayerPrefsManager.GetCollectedStars().ToString();
    }

    public void OnLevelComplete(int value)
    {
        InventoryManager.Instance.AddCoins(value);
        notify.text = PlayerPrefsManager.GetPlayerCoins().ToString();
    }

    public void OnBonusLevelComplete(int value)
    {
        InventoryManager.Instance.AddCollectedStars(value);
        notify.text = PlayerPrefsManager.GetCollectedStars().ToString();
    }

    public void PurchaseFailed(){
        notify.text = "Purchased Failed";

    }
}
