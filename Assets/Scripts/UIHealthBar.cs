using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    public Slider slider;

    public void UpdateHealth(int value)
    {
        slider.value = value;
    }
}
