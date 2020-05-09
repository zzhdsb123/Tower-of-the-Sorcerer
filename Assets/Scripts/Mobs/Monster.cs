using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health, attack, defence;
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
            Debug.Log(combatAnimation);
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
        if (health == 0)
        {
            Die();
            return;
        }
        if (attackTurn)
        {
            mobCombat = Instantiate(combatAnimation, transform.position, Quaternion.identity);
            health -= (player.attack - defence);
            if (health < 0)
            {
                health = 0;
            }
        }
        else
        {
            playerCombat = Instantiate(combatAnimation, player.gameObject.transform.position, Quaternion.identity);
            player.health -= (attack - player.defence);
        }
        player.UpdateStats();
        attackTurn = !attackTurn;
        Invoke("DeleteAnimation", 0.15f);
        Invoke("Fight", timeBetweenAttack);
    }

    bool AllowCombat()
    {
        if (player.attack <= defence)
        {
            return false;
        }
        bool turn = true;
        int playerHealth = player.health;
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
    }
}
