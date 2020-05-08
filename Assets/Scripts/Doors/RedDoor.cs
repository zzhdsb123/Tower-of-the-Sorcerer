using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoor : MonoBehaviour, Objects
{
    // Start is called before the first frame update
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        if (player.redKey > 0)
        {
            player.redKey -= 1;
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
