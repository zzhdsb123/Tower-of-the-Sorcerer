using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAuio : MonoBehaviour
{
    public AudioSource audioSource, playerPunch, mobPunch, floorMusic1, floorMusic2, floorMusic3, stairs, itemSound, hover;

    public void HoverSound()
    {
        hover.Play();
    }
    public void PickUpItem()
    {
        itemSound.Play();
    }
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

    public void PlaySong1()
    {
        floorMusic2.Stop();
        floorMusic3.Stop();
        floorMusic1.Play();
    }
    
    public void PlaySong2()
    {
        floorMusic1.Stop();
        floorMusic3.Stop();
        floorMusic2.Play();
    }
    public void PlaySong3()
    {
        floorMusic1.Stop();
        floorMusic2.Stop();
        floorMusic3.Play();
    }

    public void PlayStairs()
    {
        stairs.Play();
    }
}
