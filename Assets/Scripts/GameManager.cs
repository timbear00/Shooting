using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public List<GameObject> enemies;
    public List<Transform> enemySpawnPos;

    public GameObject Jack;
    public GameObject Jessica;

    public Text nameText;
    public Slider HealthBar;
    public Text hpText;
    public Text timeTable;

    public GameObject clearPanel;

    public float LastTime;

    private float timeLeft = 1.0f;
    private int spawnNum = 0;
    private GameObject player;

    // Start is called before the first frame update
    private void Awake()
    {
        LastTime = 10;
        Player.playerClear = false;

        if (Player.playerName == "Jack")
        {
            player = Instantiate<GameObject>(Jack);
        }
        else
        {
            player = Instantiate<GameObject>(Jessica);
        }

        nameText.text = "Name : " + Player.playerName;
        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";

        clearPanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        LastTime -= Time.deltaTime;

        if(LastTime > 0)
            timeTable.text = "남은 시간 : " + LastTime.ToString();

        else
            timeTable.text = "남은 시간 : " + 0;

        timeLeft -= Time.deltaTime;
        if( timeLeft <= 0 )
        {
            Instantiate(enemies[Random.Range(0, enemies.Capacity)], enemySpawnPos[Random.Range(0, enemySpawnPos.Capacity)].position, Quaternion.identity);

            timeLeft = 1.5f;
        }

        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";

        Clear();
    }
    
    void GameOver()
    {

    }

    void Clear()
    {
        if (LastTime <= 0)
        {
            player.SetActive(false);
            clearPanel.SetActive(true);
            Player.playerClear = true;
        }
            
    }
}
