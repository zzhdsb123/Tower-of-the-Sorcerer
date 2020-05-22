using UnityEngine;

public class AttackGem : MonoBehaviour,  Objects
{    
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.attack += 3;
        player.UpdateAttack();
        this.gameObject.SetActive(false);
        FindObjectOfType<DoorOpenAuio>().PickUpItem();
    }
}
