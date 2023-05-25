using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffColorPrices : MonoBehaviour
{
    [SerializeField] GameObject colorYellowPrice;
    [SerializeField] GameObject colorBluePrice;
    [SerializeField] GameObject colorMagentaPrice;
    [SerializeField] GameObject colorPurplePrice;
    [SerializeField] GameObject colorCyanPrice;
    [SerializeField] GameObject colorWhitePrice;
    [SerializeField] GameObject colorGreyPrice;
    [SerializeField] GameObject colorRedPrice;

    private void Update() {
        if(PlayerPrefs.GetInt("ColorYellow", 0) == 1){colorYellowPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorBlue", 0) == 1){colorBluePrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorMagenta", 0) == 1){colorMagentaPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorPurple", 0) == 1){colorPurplePrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorCyan", 0) == 1){colorCyanPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorWhite", 0) == 1){colorWhitePrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorGrey", 0) == 1){colorGreyPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ColorRed", 0) == 1){colorRedPrice.SetActive(false);}
    }
}
