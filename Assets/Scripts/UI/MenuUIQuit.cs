using UnityEngine.EventSystems;
using UnityEngine;

public class MenuUIQuit : ShopGeneral, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHover();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OffHover();
    }
}
