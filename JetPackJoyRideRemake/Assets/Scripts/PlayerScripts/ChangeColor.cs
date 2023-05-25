using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject[] body;
    private SkinnedMeshRenderer ren;
    [SerializeField] string color;

    private void Start() {
        if(SceneManager.GetActiveScene().name == "GamePlayScene"){
            changeColorOfPlayer(GameManager.colorName);
        }else{
            changeColorOfPlayer(color);
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
