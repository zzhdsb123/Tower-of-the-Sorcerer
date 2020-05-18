using UnityEngine;

public class Princess : Monster
{
    public Canvas canvas;
    public GameObject stairs;
    private bool talked = false;
    public override void Trigger()
    {
        if (!talked)
        {
            canvas.gameObject.SetActive(true);
            stairs.gameObject.SetActive(true);
            FindObjectOfType<PlayerMove>().enabled = false;
            talked = true;
        }
    }
}
