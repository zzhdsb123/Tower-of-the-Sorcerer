using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsLeft : MonoBehaviour, Objects
{
    public GameObject nextLevel;

    public void Trigger()
    {
        FindObjectOfType<LevelController>().Jump(nextLevel);
    }
}
