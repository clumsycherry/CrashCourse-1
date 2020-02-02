using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound3 : MonoBehaviour
{
    AudioSource myAudio;

    //use this for Initialization
    void Start() 
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 3.8f);
    }

    void playAudio()
    {
        myAudio.Play();
    }
}
