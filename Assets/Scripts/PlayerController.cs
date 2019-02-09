using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;

    public Transform GunPosition;

    float timeT;
    bool fireLocked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeT += Time.deltaTime;

        if (timeT > Player.attackSpeed && fireLocked)
            fireLocked = false;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, Player.playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, Player.playerSpeed * (-1) * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(Player.playerSpeed * (-1) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(Player.playerSpeed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetMouseButtonDown(0) )
        {
            if (!fireLocked)
            {
                GameObject instantiatedProjectile = Instantiate(bullet, GunPosition.position, bullet.transform.rotation);
                Object.Destroy(instantiatedProjectile, 2.0f);
                fireLocked = true;
                timeT = 0;
            }
        }
    }
}
