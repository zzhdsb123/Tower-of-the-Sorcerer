using UnityEngine;

public class RedKey : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.redKey += 1;
        player.UpdateStats();
        this.gameObject.SetActive(false);
    }

}
