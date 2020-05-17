using UnityEngine;

public class ExpShop13 : Monster
{
    public Canvas canvas;
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
    }
}
