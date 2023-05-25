using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour
{
    [SerializeField]
    private GameObject[] disabledShopGameObjects;
    [SerializeField]
    private GameObject[] enableGameObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisabledShopGameObjects(){
        for(int i = 0; i < disabledShopGameObjects.Length; i++){
            disabledShopGameObjects[i].SetActive(false);
        }
    }

     public void EnableMenuGameObjects(){
        for(int i = 0; i < enableGameObjects.Length; i++){
            enableGameObjects[i].SetActive(true);
        }
    }
}
