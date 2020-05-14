using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceGem : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.defence += 3;
        player.UpdateDefence();
        this.gameObject.SetActive(false);
    }
}
