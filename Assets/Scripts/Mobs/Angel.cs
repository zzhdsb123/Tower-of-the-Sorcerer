using UnityEngine;

public class Angel : Monster
{
    public Canvas canvas;
    public GameObject stairs;

    public override void Trigger()
    {
        if (FindObjectOfType<KeyItems>().cross)
        {
            canvas.gameObject.SetActive(true);
            stairs.gameObject.SetActive(true);
            FindObjectOfType<PlayerMove>().enabled = false;
            Player player = FindObjectOfType<Player>();
            player.attack += player.attack / 3;
            player.defence += player.defence / 3;
            player.health += player.health / 3;
            player.UpdateAttack();
            player.UpdateDefence();
            player.UpdateHealth();
            this.gameObject.SetActive(false);
        }
    }
}
