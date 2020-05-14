using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKey : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.yellowKey += 1;
        player.blueKey += 1;
        player.redKey += 1;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }

}
