using UnityEngine;

public class FloorTool : Monster
{
    public Canvas canvas;
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        FindObjectOfType<KeyItems>().floorTool = true;
        canvas.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }

}
