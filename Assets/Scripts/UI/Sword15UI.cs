using UnityEngine;

public class Sword15UI : ShopGeneral
{
    // Start is called before the first frame update
    public void BuySword()
    {
        Player player = FindObjectOfType<Player>();
        if (player.exp >= 500)
        {
            player.exp -= 500;
            player.attack += 120;
            player.UpdateAttack();
            FindObjectOfType<Sword15>().gameObject.SetActive(false);
            ExitUI();
        }
    }
}
