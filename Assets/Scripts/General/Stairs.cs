using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour, Objects
{
    public string direction;

    public void Trigger()
    {
        if (direction == "up")
        {
            FindObjectOfType<LevelController>().NextLevel();
        }
        else
        {
            FindObjectOfType<LevelController>().PreviousLevel();
        }
    }
}
