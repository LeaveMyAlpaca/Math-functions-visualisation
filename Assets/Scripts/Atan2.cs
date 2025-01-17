using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Atan2 : MonoBehaviour
{
    public Vector2 values;

    public float atanLength = 10;

    public const float radToDegConversion = 180 / Mathf.PI;

    public float angle;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * values.x);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * values.y);

        // orange
        Gizmos.color = new(226, 148, 22);
        var angleInRadians = Mathf.Atan2(values.y, values.x);
        angle = angleInRadians * radToDegConversion;

        var lineEnd = transform.position + (transform.right * atanLength);
        var rotatedLineEnd = Quaternion.AngleAxis(angle, transform.forward) * lineEnd;
        Gizmos.DrawLine(transform.position, rotatedLineEnd);

    }
}
