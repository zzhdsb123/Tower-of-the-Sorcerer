using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGreenSlime : Monster
{
    // Start is called before the first frame update
    private void Start()
    {
        health = 700;
        attack = 250;
        defence = 125;
        gold = 32;
        exp = 30;
    }
}
