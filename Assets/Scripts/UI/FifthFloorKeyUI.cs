public class FifthFloorKeyUI : ShopGeneral
{
    public void BuyYellowKey()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 10)
        {
            player.gold -= 10;
            player.yellowKey += 1;
            player.UpdateYellowKey();
        }
    }

    public void BuyBlueKey()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 50)
        {
            player.gold -= 50;
            player.blueKey += 1;
            player.UpdateBlueKey();
        }
    }

    public void BuyRedKey()
    {
        Player player = FindObjectOfType<Player>();
        if (player.gold >= 100)
        {
            player.gold -= 100;
            player.redKey += 1;
            player.UpdateRedKey();
        }
    }
}
