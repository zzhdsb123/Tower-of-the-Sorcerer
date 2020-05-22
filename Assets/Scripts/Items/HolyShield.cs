using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyShield : MonoBehaviour, Objects
{
    void Objects.Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.defence += 190;
        player.UpdateDefence();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }


}
