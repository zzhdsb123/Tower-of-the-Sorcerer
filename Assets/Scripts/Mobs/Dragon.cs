using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dragon : Monster
{
    public GameObject background;
    // Start is called before the first frame update
    private void Start()
    {
        health = 99999;
        attack = 5000;
        defence = 4000;
    }

    public override void Die()
    {
        base.Die();
        background.GetComponent<Animator>().SetTrigger("End");
        Invoke("GameEnds", 1f);
    }

    void GameEnds()
    {
        SceneManager.LoadScene("Credit");
    }
}
