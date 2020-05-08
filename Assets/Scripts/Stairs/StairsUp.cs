using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsUp : MonoBehaviour, Objects
{
    public void Trigger()
    {
        FindObjectOfType<LevelController>().NextLevel();
    }
}
