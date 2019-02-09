using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void Jack()
    {
        SceneManager.LoadScene("GJ_test");
        Player.playerName = "Jack";
        Player.attackDamage = 10;
        Player.hp = 100;
    }

    public void Jessica()
    {
        SceneManager.LoadScene("GJ_test");
        Player.playerName = "Jessica";
        Player.hp = 100;

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
