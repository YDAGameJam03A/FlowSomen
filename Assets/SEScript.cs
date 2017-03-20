using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour {
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>();
    }
    public void Play()
    {
        audioSource.Play();
    }
    public void Stop()
    {
        audioSource.Stop();
    }
}
