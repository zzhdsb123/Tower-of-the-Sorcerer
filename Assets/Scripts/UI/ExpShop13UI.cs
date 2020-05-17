using UnityEngine;

public class ExpShop13UI : ShopGeneral
{
    // Start is called before the first frame update
    public void LevelUP()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 270)
        {
            player.level += 3;
            player.health += 3000;
            player.attack += 21;
            player.defence += 21;
            player.exp -= 270;
            player.UpdateLevel();
        }

    }

    public void AddAttack()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 95)
        {
            player.attack += 17;
            player.exp -= 95;
            player.UpdateAttack();
        }
    }

    public void AddDefence()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 95)
        {
            player.defence += 17;
            player.exp -= 95;
            player.UpdateDefence();
        }
    }
}
