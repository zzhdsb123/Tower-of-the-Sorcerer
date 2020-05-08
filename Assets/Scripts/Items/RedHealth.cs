using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHealth : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.health += 200;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }
}
