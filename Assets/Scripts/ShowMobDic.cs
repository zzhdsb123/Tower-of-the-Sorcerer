using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowMobDic : MonoBehaviour
{
    public bool haveMobDic = false;
    public Transform mobPos;
    public GameObject healthPos, attackPos, defencePos;
    public GameObject mobDicUI;
    bool showingDic = false;
    List<GameObject> mobsOnScreen;
    List<GameObject> mobsStats;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && haveMobDic)
        {
            ShowMobDictionary();
        }
    }

    void ShowMobDictionary()
    {
        if (!showingDic)
        {
            GameObject[] mobs = GameObject.FindGameObjectsWithTag("Monster");
            HashSet<Sprite> spriteSet = new HashSet<Sprite>();
            List<GameObject> mobsToShow = new List<GameObject>();
            foreach (GameObject mob in mobs)
            {
                if (!spriteSet.Contains(mob.GetComponent<SpriteRenderer>().sprite))
                {
                    spriteSet.Add(mob.GetComponent<SpriteRenderer>().sprite);
                    mobsToShow.Add(mob);
                }
            }
            Vector3 currentMobPos = mobPos.position;
            Vector3 currentHealthPos = healthPos.transform.position;
            Vector3 currentAttackPos = attackPos.transform.position;
            Vector3 currentDefencePos = defencePos.transform.position;
            mobsOnScreen = new List<GameObject>();
            mobsStats = new List<GameObject>();
            foreach (GameObject mob in mobsToShow)
            {
                GameObject currentMob = Instantiate(mob, currentMobPos, Quaternion.identity);
                currentMob.transform.SetParent(mobDicUI.transform);
                mobsOnScreen.Add(currentMob);
                currentMobPos.y -= 0.32f;

                GameObject currentHealth = Instantiate(healthPos, currentHealthPos, Quaternion.identity);
                currentHealth.transform.SetParent(mobDicUI.transform);
                currentHealth.GetComponent<TextMeshPro>().text = mob.GetComponent<Monster>().health.ToString();
                currentHealth.SetActive(true);
                mobsStats.Add(currentHealth);
                currentHealthPos.y -= 0.32f;

                GameObject currentAttack = Instantiate(healthPos, currentAttackPos, Quaternion.identity);
                currentAttack.transform.SetParent(mobDicUI.transform);
                currentAttack.GetComponent<TextMeshPro>().text = mob.GetComponent<Monster>().attack.ToString();
                currentAttack.SetActive(true);
                mobsStats.Add(currentAttack);
                currentAttackPos.y -= 0.32f;

                GameObject currentDefence = Instantiate(healthPos, currentDefencePos, Quaternion.identity);
                currentDefence.transform.SetParent(mobDicUI.transform);
                currentDefence.GetComponent<TextMeshPro>().text = mob.GetComponent<Monster>().defence.ToString();
                currentDefence.SetActive(true);
                mobsStats.Add(currentDefence);
                currentDefencePos.y -= 0.32f;
            }
            mobDicUI.SetActive(true);
            this.GetComponent<LevelController>().currentLevel.SetActive(false);
        }
        else
        {
            foreach (GameObject mob in mobsOnScreen)
            {
                Destroy(mob);
            }
            foreach (GameObject mobstats in mobsStats)
            {
                Destroy(mobstats);
            }
            mobDicUI.SetActive(false);
        }
        
        showingDic = !showingDic;
    }
}
