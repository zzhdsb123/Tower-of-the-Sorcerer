using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public TextMeshPro healthText, attackText, defenceText, goldText, expText, levelText;
    public TextMeshPro yellowKeyText, blueKeyText, redKeyText;
    public int health = 1000, attack = 10, defence = 10, gold = 0, exp = 0, level = 1;
    public int yellowKey = 1, blueKey = 1, redKey = 1;
    Animator animator;
    // Start is called before the first frame update

    public void UpdateStats()
    {
        levelText.text = level.ToString();
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
        UpdateStats();
    }

    public void UpdateLevel()
    {
        levelText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        healthText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        attackText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        defenceText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateAttack()
    {
        attackText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateDefence()
    {
        defenceText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateHealth()
    {
        healthText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateBlueKey()
    {
        blueKeyText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();

    }

    public void UpdateYellowKey()
    {
        yellowKeyText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateRedKey()
    {
        redKeyText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateGold()
    {
        goldText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

    public void UpdateExp()
    {
        expText.gameObject.GetComponent<Animator>().SetTrigger("highlight");
        UpdateStats();
    }

}
