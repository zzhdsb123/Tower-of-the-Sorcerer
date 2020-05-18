using UnityEngine;
public class Thief : Monster
{
    public Canvas canvas;
    public GameObject secondFloorDoor;
    private bool doorOpened = false;
    public GameObject damagedFloor;
    public Canvas floorCanvas;
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

        else if (FindObjectOfType<KeyItems>().floorTool)
        {
            canvas.gameObject.SetActive(true);
            FindObjectOfType<PlayerMove>().enabled = false;
            damagedFloor.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        
    }
}
