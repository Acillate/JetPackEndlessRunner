using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePrefabs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "SpawnedPrefab"){
            Destroy(other.gameObject);
        }
    }
}
