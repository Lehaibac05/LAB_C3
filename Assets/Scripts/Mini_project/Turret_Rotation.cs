using UnityEngine;

public class Turret_Rotation : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 180f;
    public bool smooth = false;

    void Update()
    {
        if (target == null) return;

        Vector2 dir = target.position - transform.position;
        float angle = Vector2.SignedAngle(Vector2.up, dir);
        Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

        if (!smooth)
        {
            transform.rotation = targetRotation;
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );
        }
    }
}
