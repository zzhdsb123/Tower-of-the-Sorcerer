﻿using UnityEngine;

public class BlueKey : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.blueKey += 1;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }
}
