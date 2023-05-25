using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffGameObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject[] disabledGameObjects;
    [SerializeField]
    private GameObject[] EnableGameObjects;
    public void EnableAndDisable(){
        DisableUnessaryGameObjects();
        EnableNessaryGameObjects();
    }
    public void DisableUnessaryGameObjects(){
        for(int i = 0; i < disabledGameObjects.Length; i++){
            disabledGameObjects[i].SetActive(false);
        }
    }
    public void EnableNessaryGameObjects(){
        for (int i = 0; i < EnableGameObjects.Length; i++)
        {
            EnableGameObjects[i].SetActive(true);
        }
    }
}
