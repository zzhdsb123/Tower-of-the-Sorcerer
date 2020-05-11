using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Railing : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Animator animator = this.GetComponent<Animator>();
        animator.SetTrigger("open");
    }

    public void DestroyDoor()
    {
        this.gameObject.SetActive(false);
    }

}
