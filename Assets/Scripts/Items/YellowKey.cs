using UnityEngine;

public class YellowKey : MonoBehaviour, Objects
{
    // Start is called before the first frame update
    public void Trigger()
    {
        Player player = FindObjectOfType<Player>();
        player.yellowKey += 1;
        player.UpdateYellowKey();
        this.gameObject.SetActive(false);
    }
}
