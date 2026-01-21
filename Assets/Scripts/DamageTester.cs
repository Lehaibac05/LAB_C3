using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerHealth.TakeDamage(10);
        }
    }
}
