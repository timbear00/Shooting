using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{

    public AudioClip newMusic;
    public bool changeMusic = true;

    // Start is called before the first frame update
    void Awake()
    {

        if (changeMusic)
        {
            var go = GameObject.Find("StartBGM"); //Finds the game object called Game Music, if it goes by a different name, change this.
            go.GetComponent<AudioSource>().clip = newMusic; //Replaces the old audio with the new one set in the inspector.
            go.GetComponent<AudioSource>().Play(); //Plays the audio.
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
