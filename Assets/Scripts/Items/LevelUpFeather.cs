using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpFeather : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.level += 1;
        player.health += 1000;
        player.attack += 7;
        player.defence += 7;
        player.UpdateLevel();
        this.gameObject.SetActive(false);
    }

}
