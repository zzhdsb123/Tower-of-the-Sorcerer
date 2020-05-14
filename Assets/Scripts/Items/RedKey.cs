using UnityEngine;

public class RedKey : MonoBehaviour, Objects
{
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.redKey += 1;
        player.UpdateRedKey();
        this.gameObject.SetActive(false);
    }

}
