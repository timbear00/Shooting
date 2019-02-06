using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;

    public Transform GunPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            GameObject instantiatedProjectile = Instantiate(bullet, GunPosition.position, bullet.transform.rotation);

            Object.Destroy(instantiatedProjectile, 2.0f);
        }
    }
}
