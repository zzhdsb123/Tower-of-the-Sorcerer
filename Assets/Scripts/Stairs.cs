using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public string direction;
    // Start is called before the first frame update
    public void TriggerStair()
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
