using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    // Khai báo sự kiện
    public event Action<int> OnHealthChanged;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            Debug.Log("Player mất máu: " + health);

            // Phát sự kiện (nếu có người nghe)
            OnHealthChanged?.Invoke(health);
        }
    }

}