﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static string name;

    public void Jack()
    {
        SceneManager.LoadScene("GJ_test");
        name = "Jack";
    }

    public void jessica()
    {
        SceneManager.LoadScene("GJ_test");
        name = "Jessica";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
