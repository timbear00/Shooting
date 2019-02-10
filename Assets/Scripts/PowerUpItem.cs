using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "player" )
        {
            Player.powerUp = true;
            Player.powerUpTime = 10.0f;
            GameManager.itemCount--;
            Destroy(gameObject);
        }
    }
}
