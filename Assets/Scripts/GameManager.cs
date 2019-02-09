﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    public Text HpText;
    public Transform canvas;

    public GameObject jack;
    public GameObject jessica;

    float timeLeft = 1.0f;

    bool up;

    // Start is called before the first frame update
    void Start()
    {
        up = true;
        if(SceneChange.name == "jack")
        {
            Instantiate(jack, new Vector3(0, 0, 0), transform.rotation );
        }

        Instantiate(HpText, canvas);

    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        if( timeLeft < 0 )
        {
            if (up == true)
            {
                Instantiate(enemy1, new Vector3(0, 5, 0), enemy1.transform.rotation);
                up = false;
            }  
            else if( up ==false)
            {
                Instantiate(enemy2, new Vector3(0, -5, 0), enemy2.transform.rotation);
                up = true;
            }
            timeLeft = 3.0f;

        }
    }
    
}
