using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject player;
    // Start is called before the first frame update
    // Update is called once per frame
    
    public void NextLevel()
    {
        GameObject nextLevel = currentLevel.GetComponent<Level>().nextLevel;
        currentLevel.SetActive(false);
        nextLevel.SetActive(true);
        currentLevel = nextLevel;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromBelow.position;

    }

    public void PreviousLevel()
    {
        GameObject prevLevel = currentLevel.GetComponent<Level>().prevousLevel;
        currentLevel.SetActive(false);
        prevLevel.SetActive(true);
        currentLevel = prevLevel;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromAbove.position;
    }
}
