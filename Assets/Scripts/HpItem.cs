using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Player.hp += 25;
            if (Player.hp > 100)
            {
                Player.hp = 100;
            }
            GameManager.itemCount--;
            Destroy(gameObject);
        }
    }
}
