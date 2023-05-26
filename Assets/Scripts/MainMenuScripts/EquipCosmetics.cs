using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipCosmetics : MonoBehaviour
{
    [SerializeField] private GameObject[] hats;
    [SerializeField] private GameObject[] body;
    private SkinnedMeshRenderer ren;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("EquippedHat")){
            PlayerPrefs.SetInt("EquippedHat", 0);
            PlayerPrefs.SetInt("EquippedColor", 0);
        }

        CheckEquippedHat();
        CheckEquippedColor();
    }

    public void CheckEquippedHat(){
        switch (PlayerPrefs.GetInt("EquippedHat", 0))
        {
            case 0:
            Debug.Log("Switch Statement Case 0");
            break;
            case 1:
            Debug.Log("Switch Statement Case 1");
            SetAllHatsNotVisable("PlayerCowboyHat");
            break;
            case 2:
            Debug.Log("Switch Statement Case 2");
            SetAllHatsNotVisable("PlayerVikingHelmet");
            break;
            case 3:
            Debug.Log("Switch Statement Case 3");
            SetAllHatsNotVisable("PlayerMinerHat");
            break;
            case 4:
            Debug.Log("Switch Statement Case 4");
            SetAllHatsNotVisable("PlayerCrown");
            break;
            case 5:
            Debug.Log("Switch Statement Case 5");
            SetAllHatsNotVisable("PlayerMagicianHat");
            break;
            case 6:
            Debug.Log("Switch Statement Case 6");
            SetAllHatsNotVisable("PlayerMustache");
            break;
            case 7:
            Debug.Log("Switch Statement Case 7");
            SetAllHatsNotVisable("PlayerPajamaHat");
            break;
            case 8:
            Debug.Log("Switch Statement Case 8");
            SetAllHatsNotVisable("PlayerSombrero");
            break;
            case 9:
            Debug.Log("Switch Statement Case 9");
            SetAllHatsNotVisable("PlayerShowerCap");
            break;
            case 10:
            Debug.Log("Switch Statement Case 10");
            SetAllHatsNotVisable("PlayerPoliceCap");
            break;
            case 11:
            Debug.Log("Switch Statement Case 11");
            SetAllHatsNotVisable("PlayerPillboxHat");
            break;
            default:
            break;
        }
    }

    public void SetAllHatsNotVisable(string hatName){
        for (int i = 0; i < hats.Length; i++)
        {
            hats[i].SetActive(false);
            if(hats[i].name == hatName) hats[i].SetActive(true);
        }
    }

    public void CheckEquippedColor(){
        switch (PlayerPrefs.GetInt("EquippedColor", 0))
        {
            case 0:
            Debug.Log("green");
            changeColorOfPlayer("green");
            break;
            case 1:
            Debug.Log("yellow");
            changeColorOfPlayer("yellow");
            break;
            case 2:
            Debug.Log("Switch Statement Case 2");
            changeColorOfPlayer("blue");
            break;
            case 3:
            Debug.Log("Switch Statement Case 3");
            changeColorOfPlayer("magenta");
            break;
            case 4:
            Debug.Log("Switch Statement Case 4");
            changeColorOfPlayer("purple");
            break;
            case 5:
            Debug.Log("Switch Statement Case 5");
            changeColorOfPlayer("cyan");
            break;
            case 6:
            Debug.Log("Switch Statement Case 6");
           changeColorOfPlayer("white");
            break;
            case 7:
            Debug.Log("Switch Statement Case 7");
            changeColorOfPlayer("grey");
            break;
            case 8:
            Debug.Log("Switch Statement Case 8");
            changeColorOfPlayer("red");
            break;
            default:
            changeColorOfPlayer("green");
            break;
        }
    }

    public void changeColorOfPlayer(string newColor){
        Color MyColour = Color.clear; ColorUtility.TryParseHtmlString (newColor, out MyColour);
        for (int i = 0; i < body.Length; i++)
        {
            ren = body[i].GetComponent<SkinnedMeshRenderer>();
            ren.material.SetColor("_Color", MyColour);
        }   
    }
}
