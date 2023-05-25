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
    public void SetHatObject(GameObject hat){
        playerHatObject = hat;
    }
    public void EnterHatName(string name){
        hatName = name;
    }
    public void EnablePlayerHat(string playerHat){
        this.playerHat = playerHat;
    }    
    public void BuyHat(int cost){                  
        if(PlayerPrefs.GetInt(hatName, 0) == 1){EquipHat(); return;}
        if(playerCoins >= cost){
            PlayerPrefs.SetInt(hatName, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) - cost);
        }     
    }
    public void EquipHat(){        
        int checkHat = PlayerPrefs.GetInt(hatName, 0);
        if(checkHat == 1){
            for (int i = 0; i < Hats.Length; i++)
            {Hats[i].SetActive(false);}
            playerHatObject.SetActive(true);
            GameManager.HatName = playerHatObject.name;
        }
    }
}
