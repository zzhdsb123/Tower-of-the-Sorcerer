using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsUp23 : MonoBehaviour, Objects
{
    public void Trigger()
    {
        KeyItems keyItems = FindObjectOfType<KeyItems>();
        if (keyItems.sealKey1 && keyItems.sealKey2 && keyItems.sealKey3)
        {
            FindObjectOfType<LevelController>().NextLevel();
        }
    }
}
