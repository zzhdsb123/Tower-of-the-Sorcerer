using UnityEngine;
public class Thief : Monster
{
    public Canvas canvas;
    public GameObject secondFloorDoor;
    private bool doorOpened = false;
    // Start is called before the first frame update
    public override void Trigger()
    {
        if (!doorOpened)
        {
            canvas.gameObject.SetActive(true);
            FindObjectOfType<PlayerMove>().enabled = false;
            secondFloorDoor.GetComponent<SecondFloorDoor>().OpenDoor();
            doorOpened = true;
        }
        
    }
}
