using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private PlayerMovement playerMovement;
    [SerializeField]
   // GameObject jetPack;
   // [SerializeField]
    public Text coinText;
    public int coins = 0;
    public int collectedCoins;

    private void Start() {
        anim = GetComponent<Animator>();
        collectedCoins = 0;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Coins"){
            coins++;
            collectedCoins++;
            coinText.text = "   : " + coins.ToString();
            Destroy(other.gameObject);
        }
        if(other.tag == "Obstacle"){
          //  jetPack.SetActive(false);
            playerMovement.dead = true;
            anim.SetBool("Dead", true);
            playerMovement.deathScreen.SetActive(true);
        }
    }
    private void Update() {
        if(playerMovement.dead){
            if(transform.position.y > -4.51){
                transform.position += new Vector3(playerMovement.GetSpeed() * Time.deltaTime , playerMovement.GetDownSpeed() * 2 * Time.deltaTime, 0);
            }
        }
    }

}
