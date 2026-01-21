using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    void OnEnable()
    {
        playerHealth.OnHealthChanged += UpdateHealthUI;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    void UpdateHealthUI(int health)
    {
        Debug.Log("UI Update: " + health);
        healthText.text = "HP: " + health;
    }
}