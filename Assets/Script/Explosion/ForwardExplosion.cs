using UnityEngine;

public class ForwardExplosion : MonoBehaviour
{
    [SerializeField]
    float _power = 10f;

    private void OnTriggerStay(Collider other)
    {

       Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * _power, ForceMode.Impulse);
            print("e");
     
    }

}
