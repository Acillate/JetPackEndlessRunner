using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PurchaseHats : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Hats;
    private int playerCoins;
    private string hatName;


    private string playerHat;
    private GameObject playerHatObject;
    private string SaveHatName;
   
    private void Start() {
        playerCoins = PlayerPrefs.GetInt("Coins", 0);
    }
    public void EnterHatName(string name){
        hatName = name;
    }   
    public void BuyHat(int cost){                  
        if(playerCoins >= cost && PlayerPrefs.GetInt(hatName, 0) != 1){
            PlayerPrefs.SetInt(hatName, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) - cost);
        }     
    }

    public void changeHat(int hatNumber){
        PlayerPrefs.SetInt("EquippedHat", hatNumber);
    }
}
