using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheld11Floor : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.defence += 85;
        player.UpdateAttack();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }

}
