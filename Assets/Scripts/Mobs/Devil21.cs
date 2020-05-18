using UnityEngine;

public class Devil21 : Monster
{
    public GameObject stairsUp, stairsDown;
    // Start is called before the first frame update
    void Start()
    {
        health = 45000;
        attack = 2550;
        defence = 2250;
        gold = 375;
        exp = 330;
    }

    public override void Die()
    {
        base.Die();
        stairsUp.SetActive(true);
        stairsDown.SetActive(true);

    }

}
