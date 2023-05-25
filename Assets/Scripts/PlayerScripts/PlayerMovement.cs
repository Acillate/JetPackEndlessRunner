using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float upSpeed;
    [SerializeField]
     private float downSpeed;
    [SerializeField]
    private bool inAir = false;
    [SerializeField]
    private bool jump = false;
    private float distance;
    [SerializeField]
    private Text distanceText;
    [SerializeField]
    private float distanceMultiplier;
    public bool dead = false;
    [SerializeField]
    PlayerCollision playerCollision;
    private bool saveData = false;
    [SerializeField] public GameObject deathScreen;
    [SerializeField] private GameObject[] disableOnDeath;
    [SerializeField] private Text deathScreenCoins;
    [SerializeField] private Text deathScreenDistance;
    [SerializeField] private Text deathScreenHighScore;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!dead){
            distance += distanceMultiplier * Time.deltaTime;
            distanceText.text = "Distance: " + Mathf.FloorToInt(distance).ToString();
            speed += distance / 1000 * Time.deltaTime;
            if(speed >= 50){
                speed = 50;
            }
            if(jump && transform.position.x > 0.1){
                anim.SetBool("Jumping", true);
                anim.SetBool("Grounded", false);
                inAir = true;
                transform.position += new Vector3(speed * Time.deltaTime , upSpeed * Time.deltaTime, 0);
            }else{
                inAir = false;
                transform.position += new Vector3(speed * Time.deltaTime , 0, 0);
                
            }
            if(!inAir){
                if(transform.position.y > -4.51){
                    transform.position += new Vector3(0, downSpeed * 2 * Time.deltaTime, 0);
                }else{
                    anim.SetBool("Grounded", true);
                    anim.SetBool("Jumping", false);
                }
            
            }
        }

        if(deathScreen.activeSelf)
        {
            deathScreenCoins.text = "   : " + playerCollision.collectedCoins;
            deathScreenDistance.text = "Distance: " + Mathf.FloorToInt(distance).ToString();
            deathScreenHighScore.text = "HighScore: " + PlayerPrefs.GetInt("Distance", 0);
            for (int i = 0; i < disableOnDeath.Length; i++)
            {
                disableOnDeath[i].SetActive(false);
            }
        }
        
        if(dead && !saveData){
            //Highscore
            int currentHighestDistance = PlayerPrefs.GetInt("Distance", 0);
            if(distance > currentHighestDistance){
                PlayerPrefs.SetInt("Distance", Mathf.FloorToInt(distance));
            }
            //coins
            int currentNumberOfCoins = PlayerPrefs.GetInt("Coins", 0);
            int totalCoins = currentNumberOfCoins + playerCollision.coins;
            PlayerPrefs.SetInt("Coins", totalCoins);
            saveData = true;
        }
        
    }

    public void canJump(bool canJump)
    {
        jump = canJump;
    }

    public float GetDistance(){
        return distance;
    }
    public float GetUpSpeed(){
        return upSpeed;
    }
    public float GetDownSpeed(){
        return downSpeed;
    }
    public float GetSpeed(){
        return speed;
    }
}
