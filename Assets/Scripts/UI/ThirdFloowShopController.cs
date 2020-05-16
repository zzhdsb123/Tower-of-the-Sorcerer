using UnityEngine;

public class ThirdFloowShopController : ShopGeneral
{
    // Start is called before the first frame update

    public void AddHealth()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 25)
        {
            player.gold -= 25;
            player.health += 800;
            player.UpdateHealth();
        }
    }

    public void AddAttack()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 25)
        {
            player.gold -= 25;
            player.attack += 4;
            player.UpdateAttack();
        }
    }

    public void AddDefence()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 25)
        {
            player.gold -= 25;
            player.defence += 4;
            player.UpdateDefence();
        }
    }

    public void ExitShop()
    {
        ExitUI();
    }
}
