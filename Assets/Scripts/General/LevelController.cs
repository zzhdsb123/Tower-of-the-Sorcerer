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
        FindObjectOfType<DoorOpenAuio>().PlayStairs();

    }

    void ChangeMusic(int currentLevel, int nextLevel)
    {
        if (currentLevel >= 0 && currentLevel < 8)
        {
            if (nextLevel >= 0 && nextLevel < 8)
            {

            }
            else if (nextLevel < 16)
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong2();
            }
            else
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong3();
            }
        }
        else if (currentLevel < 16)
        {
            if (nextLevel >= 0 && nextLevel < 8)
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong1();
            }
            else if (nextLevel < 16)
            {
            }
            else
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong3();
            }
        }
        else
        {
            if (nextLevel >= 0 && nextLevel < 8)
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong1();
            }
            else if (nextLevel < 16)
            {
                FindObjectOfType<DoorOpenAuio>().PlaySong2();
            }
            else
            {
                
            }
        }
    }

    void NextLevelHelper()
    {
        GameObject nextLevel = currentLevel.GetComponent<Level>().nextLevel;

        ChangeMusic(currentLevel.GetComponent<Level>().floorInt, nextLevel.GetComponent<Level>().floorInt);

        currentLevel.SetActive(false);
        nextLevel.SetActive(true);
        currentLevel = nextLevel;
        currentLevel.GetComponent<Level>().visited = true;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromBelow.position;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
        position = null;
        FindObjectOfType<PlayerMove>().ResetTimeBetweenMove();
    }

    public void PreviousLevel()
    {
        stairs.GetComponent<LevelAnimation>().ChangeLevel();
        FindObjectOfType<PlayerMove>().enabled = false;
        Invoke("PreviousLevelHelper", 0.5f);
        FindObjectOfType<DoorOpenAuio>().PlayStairs();
    }

    void PreviousLevelHelper()
    {
        GameObject prevLevel = currentLevel.GetComponent<Level>().prevousLevel;

        ChangeMusic(currentLevel.GetComponent<Level>().floorInt, prevLevel.GetComponent<Level>().floorInt);

        currentLevel.SetActive(false);
        prevLevel.SetActive(true);
        currentLevel = prevLevel;
        player.transform.position = currentLevel.GetComponent<Level>().positionFromAbove.position;
        player.GetComponent<Player>().ResetAnimation();
        FindObjectOfType<PlayerMove>().enabled = true;
        position = null;
        FindObjectOfType<PlayerMove>().ResetTimeBetweenMove();
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
        ChangeMusic(currentLevel.GetComponent<Level>().floorInt, targetLevel.GetComponent<Level>().floorInt);
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
        FindObjectOfType<PlayerMove>().ResetTimeBetweenMove();
    }
}
