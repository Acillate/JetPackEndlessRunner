using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject[] body;
    private SkinnedMeshRenderer ren;
    [SerializeField] string color;

    private void Start() {
        changeColorOfPlayer(color);
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
