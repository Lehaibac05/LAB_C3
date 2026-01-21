using UnityEngine;

public class DamageTesterUE : MonoBehaviour
{
    public PlayerHealthUE playerHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerHealth.TakeDamage(20);
        }
    }
}
