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

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DeleteBullet()
    {
        yield return new WaitForSeconds(3);
        this.enabled = false;
    }
}
