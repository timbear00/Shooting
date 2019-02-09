using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    public GameObject Jack;
    public GameObject Jessica;

    public Text nameText;
    public Slider HealthBar;
    public Text hpText;
    public Text timeTable;

    private List<Enemy> enemies;
    public float LastTime;

    float timeLeft = 1.0f;
    
    bool up;

    // Start is called before the first frame update
    void Start()
    {
        LastTime = 180;

        up = true;

        if (Player.playerName == "Jack") {
            GameObject player = Instantiate<GameObject>(Jack);
        }
        else {
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
            if (up == true)
            {
                GameObject enemy = Instantiate(enemy1, new Vector3(0, 5, 0), enemy1.transform.rotation);
                up = false;
            }  
            else if( up ==false)
            {
                GameObject enemy = Instantiate(enemy2, new Vector3(0, -5, 0), enemy2.transform.rotation);

                up = true;
            }
            timeLeft = 3.0f;

        }

        HealthBar.value = Player.hp;
        hpText.text = Player.hp + "/100";
    }
    
}
