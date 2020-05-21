using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject nextLevel = null;
    public GameObject prevousLevel = null;
    public Transform positionFromBelow = null;
    public Transform positionFromAbove = null;
    public bool visited = false;
    public int floorInt;

    // Update is called once per frame
    void Update()
    {
        
    }
}
