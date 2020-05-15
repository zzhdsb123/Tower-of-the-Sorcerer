using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject player;
    public GameObject stairs;
    // Start is called before the first frame update
    // Update is called once per frame
    
    public void NextLevel()
    {
        stairs.GetComponent<LevelAnimation>().ChangeLevel();
        FindObjectOfType<PlayerMove>().enabled = false;
        Invoke("NextLevelHelper", 0.5f);

    }

    void NextLevelHelper()
    {
        GameObject nextLevel = currentLevel.GetComponent<Level>().nextLevel;
        currentLevel.SetActive(false);
        nextLevel.SetActive(true);
        currentLevel = nextLevel;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromBelow.position;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
    }

    public void PreviousLevel()
    {
        stairs.GetComponent<LevelAnimation>().ChangeLevel();
        FindObjectOfType<PlayerMove>().enabled = false;
        Invoke("PreviousLevelHelper", 0.5f);
    }

    void PreviousLevelHelper()
    {
        GameObject prevLevel = currentLevel.GetComponent<Level>().prevousLevel;
        currentLevel.SetActive(false);
        prevLevel.SetActive(true);
        currentLevel = prevLevel;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromAbove.position;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
    }
}
