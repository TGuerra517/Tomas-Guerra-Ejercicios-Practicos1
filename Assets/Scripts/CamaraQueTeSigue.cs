using UnityEngine;

public class CamaraQueTeSigue : MonoBehaviour
{
    public Transform Player;

    void Update()
    {
        transform.position = new Vector3(Player.position.x, 10, Player.position.z - 5);
        transform.eulerAngles = new Vector3(55, 0, 0);
    }
}
