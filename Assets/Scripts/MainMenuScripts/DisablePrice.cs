using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePrice : MonoBehaviour
{
    [SerializeField] GameObject cowboyHatPrice;
    [SerializeField] GameObject minerHatPrice;
    [SerializeField] GameObject crownHatPrice;
    [SerializeField] GameObject magicianHatPrice;
    [SerializeField] GameObject mustachePrice;
    [SerializeField] GameObject pajamaPrice;
    [SerializeField] GameObject vikingHatPrice;
    [SerializeField] GameObject sombreroHatPrice;
    [SerializeField] GameObject showerHatPrice;
    [SerializeField] GameObject policeHatPrice;
    [SerializeField] GameObject pillboxHatPrice;

    private void Update() {
        if(PlayerPrefs.GetInt("CowboyHat", 0) == 1){cowboyHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("MinerHat", 0) == 1){minerHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("Crown", 0) == 1){crownHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("MagicianHat", 0) == 1){magicianHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("Mustache", 0) == 1){mustachePrice.SetActive(false);}
        if(PlayerPrefs.GetInt("PajamaHat", 0) == 1){pajamaPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("VikingHelmet", 0) == 1){vikingHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("Sombrero", 0) == 1){sombreroHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("ShowerCap", 0) == 1){showerHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("PoliceCap", 0) == 1){policeHatPrice.SetActive(false);}
        if(PlayerPrefs.GetInt("PillboxHat", 0) == 1){pillboxHatPrice.SetActive(false);}
    }
}
