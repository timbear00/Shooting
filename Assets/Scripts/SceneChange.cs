﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public GameObject panel;

    public void Jack()
    {
        SceneManager.LoadScene("Stage1");
        Player.playerName = "Jack";
        Player.attackDamage = 20;
        Player.attackSpeed = 0.8f;
        Player.playerSpeed = 2;
        Player.hp = 100;
    }

    public void Jessica()
    {
        SceneManager.LoadScene("Stage1");
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
        Time.timeScale = 1;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }
 
    public void StartGame()
    {
        SceneManager.LoadScene("CharacterSelect");
        Variables.GameClear = false;
        
    }

    public void ContinuePlay()
    {
        if(Variables.currentScene == null)
        {
            Variables.GameClear = false;
            SceneManager.LoadScene("CharacterSelect");
        }

        else
            SceneManager.LoadScene(Variables.currentScene);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");

        Player.playerName = "Jack";
        Player.attackDamage = 20;
        Player.attackSpeed = 0.8f;
        Player.playerSpeed = 2;
        Player.hp = 100;
    }
}
