using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealKey2 : MonoBehaviour, Objects
{
    public Canvas canvas;

    public void Trigger()
    {
        canvas.gameObject.SetActive(true);
        FindObjectOfType<PlayerMove>().enabled = false;
        this.gameObject.SetActive(false);
        FindObjectOfType<KeyItems>().sealKey2 = true;
    }

    // Start is called before the first frame update
}
