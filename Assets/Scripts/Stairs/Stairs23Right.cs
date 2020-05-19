using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs23Right : MonoBehaviour, Objects
{
    public GameObject prevLevel;
    public Transform prePosition;
    public void Trigger()
    {
        FindObjectOfType<LevelController>().Jump(prevLevel, prePosition);

    }

}
