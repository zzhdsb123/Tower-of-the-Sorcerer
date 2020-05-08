using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public TextMeshPro healthText, attackText, defenceText, goldText, expText;
    public TextMeshPro yellowKeyText, blueKeyText, redKeyText;
    int health = 1000, attack = 0, defence = 10, gold = 0, exp = 0;
    int yellowKey = 1, blueKey = 1, redKey = 1;
    // Start is called before the first frame update

    public void OpenDoor(GameObject door)
    {
        
        switch (door.GetComponent<Door>().color)
        {
            case "yellow":
                if (yellowKey > 0)
                {                    
                    yellowKey -= 1;
                    door.GetComponent<Door>().OpenDoor();
                    yellowKeyText.text = yellowKey.ToString();
                }
                break;
            case "blue":
                if (blueKey > 0)
                {                    
                    blueKey -= 1;
                    door.GetComponent<Door>().OpenDoor();
                    blueKeyText.text = blueKey.ToString();
                }
                break;
            case "red":
                if (redKey > 0)
                {                    
                    redKey -= 1;
                    door.GetComponent<Door>().OpenDoor();
                    redKeyText.text = redKey.ToString();
                }
                break;
        }
    }


}
