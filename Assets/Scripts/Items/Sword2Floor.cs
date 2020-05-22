using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword2Floor : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 70;
        player.UpdateAttack();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }


}
