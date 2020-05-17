using UnityEngine;

public class Sword15 : Monster
{
    // Start is called before the first frame update
    public Canvas canvas;
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
    }
}
