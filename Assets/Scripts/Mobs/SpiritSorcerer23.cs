using UnityEngine;

public class SpiritSorcerer23 : Monster
{
    // Start is called before the first frame update
    private void Start()
    {
        health = 3000;
        attack = 2212;
        defence = 1946;
        gold = 132;
        exp = 116;
        initialDamage = FindObjectOfType<Player>().health / 3;
    }

}
