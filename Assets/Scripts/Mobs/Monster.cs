using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health, attack, defence, gold, exp;
    public int initialDamage;
    float timeBetweenAttack = 0.3f;
    bool attackTurn = true;
    Player player;
    GameObject combatAnimation, playerCombat, mobCombat;
    public virtual void Trigger()
    {
        
        player = FindObjectOfType<Player>();
        if (AllowCombat())
        {
            combatAnimation = Resources.Load<GameObject>("Prefab/Static/fight");
            FindObjectOfType<MobUI>().PlaceMobIcon(this.gameObject);
            FindObjectOfType<PlayerMove>().enabled = false;
            Fight();
        }
    }

    void DeleteAnimation()
    {
        if (playerCombat != null)
        {
            Destroy(playerCombat);
            playerCombat = null;
        }
        if (mobCombat != null)
        {
            Destroy(mobCombat);
            mobCombat = null;
        }
    }

    void Fight()
    {
        if (initialDamage > 0)
        {
            Debug.Log("?");
            playerCombat = Instantiate(combatAnimation, player.gameObject.transform.position, Quaternion.identity);
            player.health -= initialDamage;
            initialDamage = 0;
            player.UpdateStats();
            Invoke("DeleteAnimation", 0.15f);
            Invoke("Fight", timeBetweenAttack);
        }
        else
        {
            if (health == 0)
            {
                Die();
                return;
            }
            if (attackTurn)
            {
                mobCombat = Instantiate(combatAnimation, transform.position, Quaternion.identity);
                if (player.attack - defence > 0)
                {
                    health -= (player.attack - defence);
                }
                if (health < 0)
                {
                    health = 0;
                }
                FindObjectOfType<MobUI>().UpdateMobStats(health, attack, defence);
            }
            else
            {
                playerCombat = Instantiate(combatAnimation, player.gameObject.transform.position, Quaternion.identity);
                if (attack - player.defence > 0)
                {
                    player.health -= (attack - player.defence);
                }

            }
            player.UpdateStats();
            attackTurn = !attackTurn;
            Invoke("DeleteAnimation", 0.15f);
            Invoke("Fight", timeBetweenAttack);
        }
        
    }

    bool AllowCombat()
    {
        if (player.attack <= defence)
        {
            return false;
        }
        bool turn = true;
        int playerHealth = player.health;
        playerHealth -= initialDamage;
        int mobHealth = health;
        while (playerHealth > 0)
        {
            if (mobHealth <= 0)
            {
                return true;
            }
            else
            {
                if (turn)
                {
                    mobHealth -= (player.attack - defence);
                }
                else
                {
                    playerHealth -= (attack - player.defence);
                }
                turn = !turn;
            }
        }
        return false;
    }
    // Start is called before the first frame update
    void Die()
    {
        this.gameObject.SetActive(false);
        FindObjectOfType<PlayerMove>().enabled = true;
        FindObjectOfType<MobUI>().CombatOver();
        player.gold += gold;
        player.exp += exp;
        player.UpdateExp();
        player.UpdateGold();
    }
}
