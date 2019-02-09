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


    // Start is called before the first frame update
    void Start()
    {
        enemyDead = false;
        if (!Player.playerdead)
            target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (!Player.playerdead)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        Enemydead();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Player.hp -= demage;

        }

        else if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("hit!");
            enemyHp -= Player.attackDamage;
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
