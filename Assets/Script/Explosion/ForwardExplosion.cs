using UnityEngine;

public class ForwardExplosion : AbstractExplosion
{    
    protected override void Boom(GameObject Enemy)
    {
        if (Enemy.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            rigidbody.AddForce(transform.forward * Power, ForceMode.Impulse);
        }
    }

    protected override void PostBoom(GameObject Enemy)
    {
        return;
    }
    void OnTriggerStay(Collider other)
    {
        Boom(other.gameObject);
    }
}