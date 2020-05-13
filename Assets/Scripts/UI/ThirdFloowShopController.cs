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
            player.UpdateStats();
        }
    }

    public void AddAttack()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 25)
        {
            player.gold -= 25;
            player.attack += 4;
            player.UpdateStats();
        }
    }

    public void AddDefence()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 25)
        {
            player.gold -= 25;
            player.defence += 4;
            player.UpdateStats();
        }
    }

    public void ExitShop()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize -= 6;
        PlayerMove playerMove = FindObjectOfType<PlayerMove>();
        playerMove.enabled = true;
        GameObject.Find("Canvas").gameObject.SetActive(false);
    }
}
