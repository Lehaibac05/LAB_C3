using System;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public event Action<int> OnHealthChanged;
    public event Action OnDeath;

    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        OnHealthChanged?.Invoke(currentHealth);

        if (currentHealth == 0)
        {
            OnDeath?.Invoke();
        }
    }
}
