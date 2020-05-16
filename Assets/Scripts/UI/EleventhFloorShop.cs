using UnityEngine;

public class EleventhFloorShop : ShopGeneral
{
    // Start is called before the first frame update
    public void AddHealth()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 100)
        {
            player.gold -= 100;
            player.health += 4000;
            player.UpdateHealth();
        }
    }

    public void AddAttack()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 100)
        {
            player.gold -= 100;
            player.attack += 20;
            player.UpdateAttack();
        }
    }

    public void AddDefence()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 100)
        {
            player.gold -= 100;
            player.defence += 20;
            player.UpdateDefence();
        }
    }
}
