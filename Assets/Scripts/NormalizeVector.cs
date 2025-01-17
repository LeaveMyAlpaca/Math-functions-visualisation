using UnityEngine;

public class NormalizeVector : MonoBehaviour
{


    public Vector2 inputVec;
    public Vector2 outputVec;
    public float sum;

    public float pointSize = 1;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Vector3 endPointX = transform.position + Vector3.right * inputVec.x;
        Gizmos.DrawLine(transform.position, endPointX);
        Gizmos.DrawSphere(endPointX, pointSize);

        Vector3 endPointY = transform.position + Vector3.up * inputVec.y;
        Gizmos.DrawLine(transform.position, endPointY);
        Gizmos.DrawSphere(endPointY, pointSize);


        outputVec = inputVec.normalized;
        Gizmos.color = Color.blue;

        Vector3 endPointXNorm = transform.position + Vector3.right * outputVec.x;
        Gizmos.DrawLine(transform.position, endPointXNorm);
        Gizmos.DrawSphere(endPointXNorm, pointSize);

        Vector3 endPointYNorm = transform.position + Vector3.up * outputVec.y;
        Gizmos.DrawLine(transform.position, endPointYNorm);
        Gizmos.DrawSphere(endPointYNorm, pointSize);


        sum = outputVec.x + outputVec.y;
    }
}
