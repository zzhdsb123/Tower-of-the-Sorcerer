using UnityEngine;

public class SealKey1 : Monster
{
    public GameObject shit;
    public Canvas canvas;
    override public void Trigger()
    {
        shit.GetComponent<KeyItems>().sealKey1 = true;
        FindObjectOfType<PlayerMove>().enabled = false;
        canvas.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }
}
