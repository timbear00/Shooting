using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static string itemName;

    void Start()
    {
        if (itemName == "power")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("powerItem");
        }
        else if (itemName == "hp")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("hpItem");
        }
        else if (itemName == "shield")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("shieldItem");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "player" )
        {
            if( itemName == "power" )
            {
                Player.powerUp = true;
            }
            else if( itemName == "hp" )
            {
                Player.hp += 25;
                if( Player.hp > 100 )
                {
                    Player.hp = 100;
                }
            }
            else if( itemName == "shield" )
            {
                Player.shield = true;
            }

            GameManager.itemCount--;
            Destroy(gameObject);
        }
    }
}
