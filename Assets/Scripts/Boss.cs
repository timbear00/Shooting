using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    private Transform target;

    public float speed;
    public float bossHp;
    public int demage;

    private bool enemyHit;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyHit = false;

        if (!Player.playerdead && !Player.playerClear)
            target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if (!Player.playerdead && !Player.playerClear)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (gameObject.transform.position.x - target.transform.position.x > 0)
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (enemyHit)
        {
            bossHp -= Player.attackDamage;
            enemyHit = false;
        }

        BossDead();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0, 0);
            enemyHit = true;
            StartCoroutine(BossColorBack());
        }
    }

    IEnumerator BossColorBack()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
    }

    void BossDead()
    {
        if (bossHp <= 0)
        {
            Variables.GameClear = true;
            Destroy(gameObject);
            SceneManager.LoadScene("Ending");
        }
            
    }
}
