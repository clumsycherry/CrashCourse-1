using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound2 : MonoBehaviour
{
    AudioSource myAudio;

    //use this for Initialization
    void Start() 
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 1.0f);
    }

    void playAudio()
    {
        myAudio.Play();
    }
}
