using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    [SerializeField]  private Transform CenterOfMassTransform;


    private void Awake()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.Scale(CenterOfMassTransform.localPosition, transform.localScale);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.1f);
    }
}