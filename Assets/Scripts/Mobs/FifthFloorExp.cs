
using UnityEngine;

public class FifthFloorExp : Monster
{
    public Canvas canvas;
    // Start is called before the first frame update
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
    }
}
