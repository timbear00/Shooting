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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "enemy" )
        {
            hp -= 5;
            playerHp.text = "HP : " + hp;
        }
    }
}
