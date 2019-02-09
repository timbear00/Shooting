using System.Collections;
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
        Player.attackDamage = 10;
    }

    public void Jessica()
    {
        SceneManager.LoadScene("GJ_test");
        name = "Jessica";
        Player.attackDamage = 10;

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
