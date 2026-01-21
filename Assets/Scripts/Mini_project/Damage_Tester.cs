using UnityEngine;

public class Damage_Tester : MonoBehaviour
{
    public Player_Health_UE player_Health;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            player_Health.TakeDamage(10);
        }
    }
}
