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

    private Vector2 movementDirection;
    private Vector2 movementPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        enemyDead = false;
        enemyHit = false;

        movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * speed;

        if (!Player.playerdead && !Player.playerClear) 
            target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if (!Player.playerdead && !Player.playerClear)
        {
            if (Vector3.Distance(target.position, gameObject.transform.position) < 10f)
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            else
                transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y + (movementPerSecond.y * Time.deltaTime), 0);

            if (gameObject.transform.position.x - target.transform.position.x > 0)
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (enemyHit)
        {
            enemyHp -= Player.attackDamage;
            if (enemyHp <= 20) speed *= 2;
            enemyHit = false;
        }
        Enemydead();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (Player.shield)
            {
                Player.shield = false;
            }
            else
            {
                Player.hp -= demage;
            }
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
