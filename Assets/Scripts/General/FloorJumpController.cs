using UnityEngine;

public class FloorJumpController : MonoBehaviour
{
    public KeyItems keyItems;
    public Canvas canvas;
    public bool showUI = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && keyItems.floowJump)
        {
            if (!showUI)
            {
                canvas.gameObject.SetActive(true);
                FindObjectOfType<PlayerMove>().enabled = false;
                showUI = true;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                FindObjectOfType<PlayerMove>().enabled = true;
                showUI = false;
            }
            

        }
    }
}
