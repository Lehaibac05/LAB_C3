using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public void UpdateHealthText(int value)
    {
        healthText.text = "HP: " + value;
    }
}
