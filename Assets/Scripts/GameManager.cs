using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public float LastTime;

    private float timeLeft = 1.0f;
    private int spawnNum = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        LastTime = 180;

        if (Player.playerName == "Jack")
        {
            GameObject player = Instantiate<GameObject>(Jack);
        }
        else
        {
            Instantiate<GameObject>(Jessica);
        }

        nameText.text = "Name : " + Player.playerName;
        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LastTime -= Time.deltaTime;
        timeTable.text = "남은 시간 : " + LastTime.ToString();

        timeLeft -= Time.deltaTime;
        if( timeLeft <= 0 )
        {
            Instantiate(enemies[Random.Range(0, enemies.Capacity)], enemySpawnPos[Random.Range(0, enemySpawnPos.Capacity)].position, Quaternion.identity);

            timeLeft = 1.5f;
        }

        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";
    }
    
}
