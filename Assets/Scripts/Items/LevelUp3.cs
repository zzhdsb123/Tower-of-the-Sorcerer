using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp3 : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.level += 3;
        player.health += 3000;
        player.attack += 21;
        player.defence += 21;
        player.UpdateLevel();
        this.gameObject.SetActive(false);
    }

}
