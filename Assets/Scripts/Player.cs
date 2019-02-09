using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hpSetting;
    public float attackDamage;
    public float attackSpeed;

    public static bool playerdead;
    public static int hp;  

    // Start is called before the first frame update
    void Start()
    {
        hp = hpSetting;
        playerdead = false;
    }

    void Update()
    {
        Debug.Log(hp);
        PlayerDie();
    }   
    
    private void PlayerDie()
    {
        if (hp < 1)
        {
            this.gameObject.active = false;
            playerdead = true;
        }
    }

}
