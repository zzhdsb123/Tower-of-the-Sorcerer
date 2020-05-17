using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivineWater : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.health += player.health;
        player.UpdateHealth();
        this.gameObject.SetActive(false);
    }

}
