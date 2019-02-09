using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D bulletBody;

    private Vector3 target = new Vector3();
    private float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = target - myPos;
        direction.Normalize();
        bulletBody.velocity = direction * moveSpeed;

        StartCoroutine(DeleteBullet());

    }
    
    IEnumerator DeleteBullet()
    {
        yield return new WaitForSeconds(3);
        this.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
            Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
            Destroy(gameObject);
    }

}
