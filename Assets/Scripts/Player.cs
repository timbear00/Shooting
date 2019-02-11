using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hpSetting;
    public static float attackDamage;
    public static float attackSpeed;
    public static string playerName;
    public static float playerSpeed;

    public static bool playerdead;
    public static bool playerClear;
    public static int hp;

    public static bool shield;
    public static bool powerUp;

    public static float shieldTime;
    public static float powerUpTime;

    // Start is called before the first frame update
    void Start()
    {
        hp = hpSetting;
        playerdead = false;
        shield = false;
        powerUp = false;

    }

    void FixedUpdate()
    {
        //Debug.Log(hp);
        PlayerDie();
        itemCheck();
    }   
    
    private void PlayerDie()
    {
        if (hp < 1)
        {
            gameObject.SetActive(false);
            playerdead = true;
        }
    }

    private void itemCheck()                
    {                                       
        if( powerUp == true )
        {
            Debug.Log("Hello");
            powerUpTime -= Time.deltaTime;  
            if( powerUpTime <= 0 )          
            {                               
                powerUp = false;
                if (Player.playerName == "Jack")
                {
                    Player.attackDamage = 20;
                    Player.attackSpeed = 0.8f;
                    Player.playerSpeed = 2;
                }
                else if (Player.playerName == "Jessica")
                {
                    Player.attackDamage = 10;
                    Player.attackSpeed = 0.3f;
                    Player.playerSpeed = 3;
                }
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }                               
            else                            
            {               
                if ( Player.playerName == "Jack" )
                {
                    Player.attackDamage = 40;
                    Player.attackSpeed = 0.2f;
                    Player.playerSpeed = 4f;
                }
                else if ( Player.playerName == "Jessica" )
                {
                    Player.attackDamage = 20;
                    Player.attackSpeed = 0.05f;
                    Player.playerSpeed = 6f;
                }
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0, 0);
            }
        }
        else if ( shield )
        {
            shieldTime -= Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1f, 1f);
            if ( shieldTime <= 0 )
            {
                shield = false;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }
        }
        else if ( !shield ) gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }

}
