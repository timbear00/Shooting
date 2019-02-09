using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;

    public float speed;
    public float enemyHp;
    public int demage;

    public bool enemyDead;
    private bool enemyHit;


    // Start is called before the first frame update
    void Start()
    {
        enemyDead = false;
        enemyHit = false;
        if (!Player.playerdead)
            target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if (!Player.playerdead)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if(enemyHit)
        {
            enemyHp -= Player.attackDamage;
            enemyHit = false;
        }
        Enemydead();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Player.hp -= demage;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0, 0);
            enemyHit = true;
        }
    }

    private void Enemydead()
    {
        if(enemyHp <= 0)
        {
            enemyDead = true;
            Destroy(gameObject);
        }
    }
}
