using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hpSetting;
    public float attackDamage;
    public float attackSpeed;

    public static int hp;

    public Text playerHp;  

    // Start is called before the first frame update
    void Start()
    {
        hp = hpSetting;
        playerHp.text = "HP : " + hp;
    }

    private void FixedUpdate()
    {
        playerHp.text = "HP : " + hp;
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
