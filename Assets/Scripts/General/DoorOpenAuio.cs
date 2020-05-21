using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAuio : MonoBehaviour
{
    public AudioSource audioSource, playerPunch, mobPunch;
    // Start is called before the first frame update
    public void OpenDoor()
    {
        audioSource.Play();
    }

    public void PlayerPunch()
    {
        playerPunch.Play();
    }

    public void MobPunch()
    {
        mobPunch.Play();
    }
}
