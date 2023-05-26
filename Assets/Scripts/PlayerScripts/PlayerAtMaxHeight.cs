using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtMaxHeight : MonoBehaviour
{
    private Vector2 screenBounds;
    private void Start() {
       screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    private void LateUpdate() {
        Vector3 viewPos = transform.position;
        viewPos.y = Mathf.Clamp(viewPos.y, -6.8f, 4f);
        transform.position = viewPos;
    }
}
