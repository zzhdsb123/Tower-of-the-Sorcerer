using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthFloorExpUI : ShopGeneral
{
    // Start is called before the first frame update
    public void LevelUP()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 100)
        {
            player.level += 1;
            player.health += 1000;
            player.attack += 7;
            player.defence += 7;
            player.exp -= 100;
            player.UpdateStats();
        }
        
    }

    public void AddAttack()
    {
        Player player = FindObjectOfType<Player>();
        if(player.exp >= 30)
        {
            player.attack += 5;
            player.exp -= 30;
            player.UpdateStats();
        }
    }

    public void AddDefence()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 30)
        {
            player.defence += 5;
            player.exp -= 30;
            player.UpdateStats();
        }
    }
}
