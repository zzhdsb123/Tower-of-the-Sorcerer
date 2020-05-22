using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBlue : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.health += 500;
        player.UpdateHealth();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }
}
