using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerMenu : MonoBehaviour
{
    public GameObject nextText;

    public void LoadNextText()
    {
        nextText.GetComponent<Animator>().SetTrigger("Play");
    }
}
