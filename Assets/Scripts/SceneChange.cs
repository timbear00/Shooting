using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void Jack()
    {
        SceneManager.LoadScene("1stMap");
        Player.playerName = "Jack";
        Player.attackDamage = 20;
        Player.attackSpeed = 0.8f;
        Player.playerSpeed = 2;
        Player.hp = 100;
    }

    public void Jessica()
    {
        SceneManager.LoadScene("1stMap");
        Player.playerName = "Jessica";
        Player.attackDamage = 10;
        Player.attackSpeed = 0.3f;
        Player.playerSpeed = 3;
        Player.hp = 100;

    }

    public void GoToStage2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void GoToBossStage()
    {
        SceneManager.LoadScene("Boss");
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }
 
}
