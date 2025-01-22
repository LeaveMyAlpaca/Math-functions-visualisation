using System;
using TMPro;
using UnityEngine;

public class DotProduct : MonoBehaviour
{
    public Vector2 A;
    public Vector2 B;

    public float output;
    // https://www.youtube.com/watch?v=2PrSUK1VrKA
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + A);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + B);

        output = Vector2.Dot(A, B);
    }

}
