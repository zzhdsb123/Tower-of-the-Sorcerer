using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopGeneral : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnHover()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize += 6;
    }

    public void OffHover()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize -= 6;
    }

    public void ExitUI()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize -= 6;
        PlayerMove playerMove = FindObjectOfType<PlayerMove>();
        playerMove.enabled = true;
        this.transform.parent.transform.parent.gameObject.SetActive(false);
    }
}
