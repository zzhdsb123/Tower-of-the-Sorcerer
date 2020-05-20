using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class MenuUI : ShopGeneral, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject backgroundImg;
    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundImg.GetComponent<Animator>().SetTrigger("Play");
        Invoke("LoadNextScene", 1f);
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

    void LoadNextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
