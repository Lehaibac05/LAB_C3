using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthUnityEvent : MonoBehaviour
{
    public int health = 100;
    public UnityEvent<int> OnHealthChanged;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            health -= 10;
            Debug.Log("[Lab6] Player mất máu: " + health);
            OnHealthChanged.Invoke(health);
        }
    }
}