using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;

    public float speed;
    public float enemyHp;
    public int demage;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "player" )
        {
            Player.hp -= demage;
        }
    }
}
