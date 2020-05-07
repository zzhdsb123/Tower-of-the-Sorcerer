using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int yellowKey = 1;
    int blueKey = 1;
    int redKey = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenDoor(GameObject door )
    {
        switch (door.GetComponent<Door>().color)
        {
            case "yellow":
                if (yellowKey > 0)
                {
                    door.GetComponent<Door>().OpenDoor();
                    yellowKey -= 1;
                }
                break;
            case "blue":
                if (blueKey > 0)
                {
                    door.GetComponent<Door>().OpenDoor();
                    blueKey -= 1;
                }
                break;
            case "red":
                if (redKey > 0)
                {
                    door.GetComponent<Door>().OpenDoor();
                    redKey -= 1;
                }
                break;
        }
    }
}
