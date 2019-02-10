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
    public string stageName;

    public GameObject clearPanel;
    public GameObject MenuPanel;

    public float LastTime;

    public float timeLeft = 1.0f;
    private int spawnNum = 0;
    private GameObject player;

    public GameObject item;
    private float itemTimeLeft;
    private int itemType;
    public static int itemCount;

    // Start is called before the first frame update
    private void Awake()
    {
        itemCount = 0;
        itemTimeLeft = Random.Range(5.0f, 10.0f);
        Debug.Log(itemTimeLeft);

        if (Player.playerName == "Jack")
        {
            player = Instantiate<GameObject>(Jack, new Vector3 (0,0,0), transform.rotation);
            player.SetActive(true);
        }
        else
        {
            player = Instantiate<GameObject>(Jessica, new Vector3(0, 0, 0), transform.rotation);
            player.SetActive(true);
        }

        Player.playerClear = false;
        Variables.currentScene = stageName;

        nameText.text = "Name : " + Player.playerName;
        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";

        clearPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        LastTime -= Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if(LastTime > 0)
            timeTable.text = "남은 시간 : " + LastTime.ToString();

        else
            timeTable.text = "남은 시간 : " + 0;

        timeLeft -= Time.deltaTime;
        if( timeLeft <= 0 )
        {
            Instantiate(enemies[Random.Range(0, enemies.Capacity)], enemySpawnPos[Random.Range(0, enemySpawnPos.Capacity)].position, Quaternion.identity);
            Instantiate(enemies[Random.Range(0, enemies.Capacity)], enemySpawnPos[Random.Range(0, enemySpawnPos.Capacity)].position, Quaternion.identity);

            timeLeft = 1.5f;
        }

        #region item spawn

        itemTimeLeft -= Time.deltaTime;
        if (itemTimeLeft <= 0 && itemCount <= 5)
        {
            Instantiate(item, new Vector3(Random.Range(-25.0f, 25.0f), Random.Range(-13.0f, 13.0f), 0), Quaternion.identity);
            itemCount++;

            itemType = Random.Range(0, 3);
            if (itemType == 0)
            {
                Item.itemName = "power";
            }
            else if (itemType == 1)
            {
                Item.itemName = "hp";
            }
            else if (itemType == 2)
            {
                Item.itemName = "shield";
            }

            itemTimeLeft = Random.Range(5.0f, 10.0f);
            //Debug.Log("Item type : " + Item.itemName + ", Item Count : " + itemCount+", TimeLeft : "+itemTimeLeft);
        }

        #endregion

        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";

        Clear();
    }
    
    void GameOver()
    {

    }

    void Clear()
    {
        if (LastTime <= 0 && stageName != "Boss")
        {
            player.SetActive(false);
            clearPanel.SetActive(true);
            Player.playerClear = true;
        }
        
        else if(stageName == "Boss" && Variables.GameClear)
        {
            SceneManager.LoadScene("Ending");
            player.SetActive(false);
        }
    }
}
