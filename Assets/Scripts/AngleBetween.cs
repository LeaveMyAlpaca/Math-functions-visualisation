using System;
using TMPro;
using UnityEngine;

public class AngleBetween : MonoBehaviour
{
    public Vector2 A;
    public Vector2 B;

    public float angle;
    public TMP_Text angleText;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + A);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + B);

        angle = GetAngleBetween(A, B);
        angleText.text = $"Angle in deg. {Math.Round(angle, 1)}";
    }
    public float GetAngleBetween(Vector2 A, Vector2 B)
    {
        float DotProd = Vector2.Dot(A, B);
        float Length = A.magnitude * B.magnitude;
        return Mathf.Rad2Deg * ((float)Mathf.Acos(DotProd / Length));
    }
}
