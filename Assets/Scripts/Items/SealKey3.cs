using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealKey3 : MonoBehaviour, Objects
{
    public Canvas canvas;
    public void Trigger()
    {
        canvas.gameObject.SetActive(true);
        FindObjectOfType<PlayerMove>().enabled = false;
        this.gameObject.SetActive(false);
        FindObjectOfType<KeyItems>().sealKey3 = true;
    }

}
