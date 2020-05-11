using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public TextMeshPro healthText, attackText, defenceText, goldText, expText;
    public TextMeshPro yellowKeyText, blueKeyText, redKeyText;
    public int health = 1000, attack = 10, defence = 10, gold = 0, exp = 0;
    public int yellowKey = 1, blueKey = 1, redKey = 1;
    Animator animator;
    // Start is called before the first frame update

    public void UpdateStats()
    {
        healthText.text = health.ToString();
        attackText.text = attack.ToString();
        defenceText.text = defence.ToString();
        goldText.text = gold.ToString();
        expText.text = exp.ToString();
        yellowKeyText.text = yellowKey.ToString();
        blueKeyText.text = blueKey.ToString();
        redKeyText.text = redKey.ToString();
    }

    public void ResetAnimation()
    {
        animator.SetTrigger("idle");
    }

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }



}
