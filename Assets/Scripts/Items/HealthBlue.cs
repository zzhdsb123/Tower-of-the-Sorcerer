using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBlue : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.health += 500;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }
}
