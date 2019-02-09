using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int hp = 100;
    public Text playerHp;
    public int hpSetting;
    public float attackDamage;
    public float attackSpeed;

    // Start is called before the first frame update
    void Start()
    {
        hp = hpSetting;
        playerHp.text = "HP : " + hp;
    }

    void Update()
    {
        Debug.Log(hp);
        playerHp.text = "Hello";
        PlayerDie();
    }   
    
    private void PlayerDie()
    {
        if (hp < 1)
        {
            this.gameObject.active = false;
        }
    }

}
