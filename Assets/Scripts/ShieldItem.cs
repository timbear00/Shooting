using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Player.shield = true;
            Player.shieldTime = 30.0f;
            GameManager.itemCount--;
            Destroy(gameObject);
        }
    }
}
