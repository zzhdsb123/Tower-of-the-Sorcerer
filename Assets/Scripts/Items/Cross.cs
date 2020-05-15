using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : Monster
{
    public Canvas canvas;
    // Start is called before the first frame update
    public override void Trigger()
    {
        canvas.gameObject.SetActive(true);
        FindObjectOfType<PlayerMove>().enabled = false;
        FindObjectOfType<KeyItems>().cross = true;
        this.gameObject.SetActive(false);
    }
}
