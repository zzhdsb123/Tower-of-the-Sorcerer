using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    public void ChangeLevel()
    {
        animator.SetTrigger("levelChange");
    }
}
