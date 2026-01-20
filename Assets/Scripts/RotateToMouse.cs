using UnityEngine;
using TMPro;

public class RotateToMouse : MonoBehaviour
{
    public TextMeshProUGUI angleText;

    void Update()
    {
        Vector3 mouseWorld =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction =
            mouseWorld - transform.position;

        float angle =
            Vector2.SignedAngle(Vector2.up, direction);

        transform.rotation =
            Quaternion.Euler(0, 0, angle);

        angleText.text =
            "Angle: " + angle.ToString("F1") + "°";
    }
}
