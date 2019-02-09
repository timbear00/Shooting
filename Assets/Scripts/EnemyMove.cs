﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform target;

    public float speed;
    public float enemyHp;
    public int demage;


    // Start is called before the first frame update
    void Start()
    {
        if(!Player.playerdead)
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (!Player.playerdead)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "player" )
        {
            Player.hp -= demage;
            
        }

        if(collision.gameObject.tag == "Bullet")
        {
            enemyHp -= Player.attackDamage;
        }

    }

}
