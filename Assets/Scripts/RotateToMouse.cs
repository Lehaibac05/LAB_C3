using UnityEngine;
using TMPro;

public class RotateToMouse : MonoBehaviour
{
    public TextMeshProUGUI angleText;

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f; // khoảng cách từ camera tới object

        Vector3 mouseWorld =
            Camera.main.ScreenToWorldPoint(mousePos);

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
