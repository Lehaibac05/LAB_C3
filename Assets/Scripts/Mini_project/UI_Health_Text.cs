using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health_Text : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public void UpdateHealthText(int value)
    {
        healthText.text = "HP: " + value;
    }
}
