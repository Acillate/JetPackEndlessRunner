using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorShop : MonoBehaviour
{
    private int playerCoins;
    private string colorName;
    [SerializeField]private GameObject Player;
    private string SaveHatName;
    private string buttonTag;
    
   
    private void Start() {
        playerCoins = PlayerPrefs.GetInt("Coins", 0);
    }  
     public void EnterColorName(string name){
        colorName = name;
    }
    public void BuyColor(int cost){                  
        if(PlayerPrefs.GetInt(colorName, 0) == 1){EquipColor(); return;}
        if(playerCoins >= cost){
            PlayerPrefs.SetInt(colorName, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) - cost);
        }     
    }
    public void EquipColor(){        
        ChangeColor changeColor = Player.GetComponent<ChangeColor>();
        changeColor.changeColorOfPlayer(GameManager.colorName);
    } 

    public void GetButton(Button button){
        GameManager.colorName = button.tag;
    }
}
