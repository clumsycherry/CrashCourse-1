using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound : MonoBehaviour
{
    AudioSource myAudio;

    //use this for Initialization
    void Start() 
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 2.0f);
    }

    void playAudio()
    {
        myAudio.Play();
    }
}


