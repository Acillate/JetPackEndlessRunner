using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHat : MonoBehaviour
{
    private string hatName;
    public GameObject hat;
    public GameObject[] disableHats;

    private void Start() {
        hatName = GameManager.HatName;
        Debug.Log(hatName);
        for (int i = 0; i < disableHats.Length; i++)
        {
            if(disableHats[i].name != hatName){
                disableHats[i].SetActive(false);
            }
            
        }
    }
}
