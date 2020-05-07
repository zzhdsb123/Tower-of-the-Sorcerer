using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    public string color = "yellow";
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        
    }

    public void DestroyDoor()
    {
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    public void OpenDoor()
    {
        animator.SetBool("open", true);
    }
}
