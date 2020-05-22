using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield2Floor : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.defence += 50;
        player.UpdateDefence();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }

}
