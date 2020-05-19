using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject player;
    public GameObject stairs;
    GameObject targetLevel;
    Transform position = null;
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
        currentLevel.GetComponent<Level>().visited = true;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromBelow.position;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
        position = null;
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
        position = null;
    }

    public void Jump(GameObject level, Transform positionIn = null)
    {
        targetLevel = level;
        stairs.GetComponent<LevelAnimation>().ChangeLevel();
        FindObjectOfType<PlayerMove>().enabled = false;
        if (positionIn != null)
        {
            position = positionIn;
        }
        Invoke("FloorJumpHelper", 0.5f);
    }

    void FloorJumpHelper()
    {
        currentLevel.SetActive(false);
        targetLevel.SetActive(true);
        currentLevel = targetLevel;
        
        if (position != null)
        {
            player.transform.position = position.position;
        }
        else
        {
            player.transform.position = currentLevel.GetComponent<Level>().positionFromBelow.position;
        }
        position = null;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
    }
}
