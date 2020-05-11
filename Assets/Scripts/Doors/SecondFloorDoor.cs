using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorDoor : MonoBehaviour, Objects
{
    public void Trigger()
    {
        
    }

    public void OpenDoor()
    {
        this.gameObject.SetActive(false);
    }
    
}
