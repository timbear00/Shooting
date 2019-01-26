using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int hp = 100;

    public Text playerHp;

    // Start is called before the first frame update
    void Start()
    {
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
