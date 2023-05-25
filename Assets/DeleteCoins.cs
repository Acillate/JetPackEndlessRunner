using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SpawnedPrefab")){
            Destroy(other.gameObject);
        }
    }
}
