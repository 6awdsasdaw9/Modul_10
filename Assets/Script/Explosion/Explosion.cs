using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Audio _audio;
    [SerializeField] private float _power;
    [SerializeField] private float _radiys;

    private void Awake()
    {
    
            _audio = GetComponentInChildren<Audio>();
        
    }


    public void Boom(GameObject Enemy)
    {
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);
        if (distance < _radiys)
        {
            Vector3 direction = Enemy.transform.position - transform.position;
            Enemy.GetComponent<Rigidbody>().AddForce(direction.normalized * _power * (_radiys - distance));
          
                _audio?.PlaySound();
            
        }
    }
            
    private void OnCollisionEnter(Collision collision)
    {
        Boom(collision.gameObject);
    }


}
