using UnityEngine;
public class FifthFloorKeyMerchant : Monster
{
    public Canvas canvas;
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
    }
}
