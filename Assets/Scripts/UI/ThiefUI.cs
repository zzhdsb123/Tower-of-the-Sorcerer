using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefUI : ShopGeneral
{
    // Start is called before the first frame update
    public void CloseThiefUI()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().fontSize -= 6;
        PlayerMove playerMove = FindObjectOfType<PlayerMove>();
        playerMove.enabled = true;
        GameObject.Find("Canvas").gameObject.SetActive(false);
    }
}
