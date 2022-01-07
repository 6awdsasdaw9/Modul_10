using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Explosion : AbstractExplosion
{
    [SerializeField] private int _bonusScore = 0;

    IEnumerator _bafTimer;
  
    protected override void Boom(GameObject Enemy)
    {
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);
        if (distance < Radiys)
        {
            Vector3 direction = Enemy.transform.position - transform.position;
            Enemy.GetComponent<Rigidbody>().AddForce(direction.normalized * Power * (Radiys - distance));

            Audio?.PlaySound();
        }
    }

    protected override void PostBoom(GameObject Enemy)
    {
        Rigidbody rigidbody = Enemy.GetComponent<Rigidbody>();

        rigidbody.mass-= 0.01f;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Boom(collision.gameObject);

        for (int i = 0; i < _bonusScore; i++)
        {
            Score.AddCount();
        }   
    }

    private void OnCollisionExit(Collision collision)
    {
        PostBoom(collision.gameObject);
    }

}
