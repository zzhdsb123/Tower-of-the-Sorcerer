using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MobUI : MonoBehaviour
{
    public Transform mobTransform;
    public TextMeshPro health, attack, defence, healthText, attackText, defenceText;
    GameObject monster;
    // Start is called before the first frame update
    public void PlaceMobIcon(GameObject mob)
    {
        monster = Instantiate(mob, mobTransform.position, Quaternion.identity);
        Vector3 newScale = monster.transform.localScale;
        newScale.x *= 2;
        newScale.y *= 2;
        monster.transform.localScale = newScale;
        healthText.text = "Health";
        attackText.text = "Attack";
        defenceText.text = "Defence";
    }

    public void UpdateMobStats(int healthIn, int attackIn, int defenceIn)
    {
        health.text = healthIn.ToString();
        attack.text = attackIn.ToString();
        defence.text = defenceIn.ToString();
    }

    public void CombatOver()
    {
        Destroy(monster.gameObject);
        monster = null;
        health.text = "";
        attack.text = "";
        defence.text = "";
        healthText.text = "";
        attackText.text = "";
        defenceText.text = "";
    }

    
}
