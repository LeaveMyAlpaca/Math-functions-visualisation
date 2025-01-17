using UnityEngine;

public class LineRotation : MonoBehaviour
{
    public float angle;
    public float visionDistance = 10;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        var lineEnd = transform.position + (transform.right * visionDistance);
        var rotatedLineEnd = Quaternion.AngleAxis(angle, transform.forward) * lineEnd;
        Gizmos.DrawLine(transform.position, rotatedLineEnd);


    }
}
