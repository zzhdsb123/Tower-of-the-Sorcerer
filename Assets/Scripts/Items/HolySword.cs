using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolySword : MonoBehaviour,  Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 150;
        player.UpdateAttack();
        this.gameObject.SetActive(false);
    }

}
