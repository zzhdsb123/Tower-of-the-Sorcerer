using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : MonoBehaviour, Objects
{
    // Start is called before the first frame update
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 10;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }
}
