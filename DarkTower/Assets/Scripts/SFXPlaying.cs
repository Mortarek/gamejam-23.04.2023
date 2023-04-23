using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource Music;
    private float i = 0;
    // Start is called before the first frame update
    public void playMusic()
    {
        Music.Play();
    }
    void Start()
    {
            playMusic();
    }

}
