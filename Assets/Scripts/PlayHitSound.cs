using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHitSound : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playSelectedAudio()
    {
        audioSource.Play();
    }
   
}
