using UnityEngine;

public class MagicSnowFlake : Monster
{
    public Canvas canvas;
    // Start is called before the first frame update
    public override void Trigger()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
        FindObjectOfType<KeyItems>().floowJump = true;
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }
}
