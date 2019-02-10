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

    // Start is called before the first frame update
    void Start()
    {
        hp = hpSetting;
        playerdead = false;
        shield = false;
        powerUp = false;
    }

    void Update()
    {
        //Debug.Log(hp);
        PlayerDie();
    }   
    
    private void PlayerDie()
    {
        if (hp < 1)
        {
            gameObject.SetActive(false);
            playerdead = true;
        }
    }

}
