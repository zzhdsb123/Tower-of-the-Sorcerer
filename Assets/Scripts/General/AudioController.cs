using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource1, audioSource2, audioSource3;

    public void PlaySong1()
    {
        audioSource2.Stop();
        audioSource3.Stop();
        audioSource1.Play();
    }

    public void PlaySong2()
    {
        audioSource1.Stop();
        audioSource3.Stop();
        audioSource2.Play();
    }

    public void PlaySong3()
    {
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Play();
    }
}
