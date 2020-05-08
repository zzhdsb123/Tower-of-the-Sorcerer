using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsDown : MonoBehaviour, Objects
{
    public void Trigger()
    {
        FindObjectOfType<LevelController>().PreviousLevel();
    }

}
