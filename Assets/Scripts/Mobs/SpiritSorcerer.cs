using UnityEngine;

public class SpiritSorcerer : Monster
{
    // Start is called before the first frame update
    private void Start()
    {
        health = 1500;
        attack = 830;
        defence = 730;
        gold = 80;
        exp = 70;
        initialDamage = FindObjectOfType<Player>().health / 3;
    }
}
