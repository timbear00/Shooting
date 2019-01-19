using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.UpArrow ) )
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey( KeyCode.DownArrow ) )
        {
            transform.position += new Vector3(0, speed * (-1) * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey( KeyCode.LeftArrow ) )
        {
            transform.position += new Vector3(speed * (-1) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey( KeyCode.RightArrow ) )
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

    }
}
