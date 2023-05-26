using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCoins : MonoBehaviour
{
    public int Coins;
    private Text coinText;
    void Start()
    {
        Coins = PlayerPrefs.GetInt("Coins", 0);
        coinText = GetComponent<Text>();
        coinText.text = "   : " + Coins;

        if(!PlayerPrefs.HasKey("CowboyHat")){
            PlayerPrefs.SetInt("CowboyHat", 0);
            PlayerPrefs.SetInt("MinerHat", 0);
            PlayerPrefs.SetInt("Crown", 0);
            PlayerPrefs.SetInt("MagicianHat", 0);
            PlayerPrefs.SetInt("Mustache", 0);
            PlayerPrefs.SetInt("PajamaHat", 0);
            PlayerPrefs.SetInt("VikingHelmet", 0);
            PlayerPrefs.SetInt("Sombrero", 0);
            PlayerPrefs.SetInt("ShowerCap", 0);
            PlayerPrefs.SetInt("PoliceCap", 0);
            PlayerPrefs.SetInt("PillboxHat", 0);
        } 
        if(!PlayerPrefs.HasKey("ColorGreen")){
            PlayerPrefs.SetInt("ColorGreen", 1);
            PlayerPrefs.SetInt("ColorYellow", 0);
            PlayerPrefs.SetInt("ColorMagenta", 0);
            PlayerPrefs.SetInt("ColorBlue", 0);
            PlayerPrefs.SetInt("ColorPurple", 0);
            PlayerPrefs.SetInt("ColorCyan", 0);
            PlayerPrefs.SetInt("ColorWhite", 0);
            PlayerPrefs.SetInt("ColorGrey", 0);
            PlayerPrefs.SetInt("ColorRed", 0);
        } 

       
    }

    private void Update() {
        Coins = PlayerPrefs.GetInt("Coins", 0);
        coinText = GetComponent<Text>();
        coinText.text = "   : " + Coins;
    }
}
