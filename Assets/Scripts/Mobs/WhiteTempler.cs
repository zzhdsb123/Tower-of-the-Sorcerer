using UnityEngine;

public class WhiteTempler : Monster
{
    // Start is called before the first frame update
    private void Start()
    {
        health = 1300;
        attack = 300;
        defence = 150;
        gold = 40;
        exp = 35;
        initialDamage = FindObjectOfType<Player>().health / 4;
    }
}
