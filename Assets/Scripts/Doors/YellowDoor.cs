using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowDoor : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        if (player.yellowKey > 0)
        {
            player.yellowKey -= 1;
            OpenDoor();
            player.UpdateStats();
        }
    }

    void OpenDoor()
    {
        Animator animator = this.GetComponent<Animator>();
        animator.SetTrigger("open");
    }

    public void DestroyDoor()
    {
        this.gameObject.SetActive(false);
    }
}
