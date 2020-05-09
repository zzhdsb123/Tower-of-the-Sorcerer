using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDic : MonoBehaviour, Objects
{
    void Objects.Trigger()
    {
        ShowMobDic showMobDic = FindObjectOfType<ShowMobDic>();
        showMobDic.haveMobDic = true;
        this.gameObject.SetActive(false);
    }


}
