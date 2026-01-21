using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthUE : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    [Header("Unity Events")]
    public UnityEvent<int> OnHealthChanged;
    public UnityEvent OnDeath;

    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        OnHealthChanged.Invoke(currentHealth);

        if (currentHealth == 0)
        {
            OnDeath.Invoke();
        }
    }
}