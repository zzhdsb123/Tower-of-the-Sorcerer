using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9Sword : MonoBehaviour, Objects
{
    // Start is called before the first frame update

    void Objects.Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 70;
        player.UpdateAttack();
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
}
