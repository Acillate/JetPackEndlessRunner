using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorShop : MonoBehaviour
{
    private int playerCoins;
    private string colorName;
    
   
    private void Start() {
        playerCoins = PlayerPrefs.GetInt("Coins", 0);
    }  
     public void EnterColorName(string name){
        colorName = name;
    }
    public void BuyColor(int cost){                  
        if(playerCoins >= cost && PlayerPrefs.GetInt(colorName, 0) != 1){
            PlayerPrefs.SetInt(colorName, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) - cost);
        }     
    }

    public void changeColor(int colorNumber){
        PlayerPrefs.SetInt("EquippedColor", colorNumber);
    }
}
