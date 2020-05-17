using UnityEngine;

public class Shield15UI : ShopGeneral
{
    // Start is called before the first frame update
    public void BuyShield()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 500)
        {
            player.gold -= 500;
            player.defence += 120;
            player.UpdateDefence();
            GameObject.Find("merchant").SetActive(false);
            ExitUI();
        }
    }
}
