using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    public static int hp = 100;
    public Text playerHp;
=======
    public int hpSetting;
    public float attackDamage;
    public float attackSpeed;

    public static int hp;

    public Text playerHp;  
>>>>>>> 136f8467d7a6fc3f3a6b5100cc2e6bd6478ecf3f

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
