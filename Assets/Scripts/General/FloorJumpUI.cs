using UnityEngine;
using UnityEngine.EventSystems;

public class FloorJumpUI : ShopGeneral, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject floor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHover();
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        OffHover();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (floor.GetComponent<Level>().visited)
        {
            FindObjectOfType<LevelController>().Jump(floor);
            this.transform.parent.transform.parent.gameObject.SetActive(false);
            this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize -= 6;
            FindObjectOfType<FloorJumpController>().showUI = false;
        }
    }
}
