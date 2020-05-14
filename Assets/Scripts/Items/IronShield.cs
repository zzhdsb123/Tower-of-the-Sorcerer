using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronShield : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.defence += 10;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }

}
