using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoor : MonoBehaviour, Objects
{
    // Start is called before the first frame update
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        if (player.blueKey > 0)
        {
            player.blueKey -= 1;
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
