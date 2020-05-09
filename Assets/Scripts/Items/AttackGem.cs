﻿using UnityEngine;

public class AttackGem : MonoBehaviour,  Objects
{    
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 3;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }
}
