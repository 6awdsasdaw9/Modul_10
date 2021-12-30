using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void Desh()
    {
        _rigidBody.AddForce(5,0,0, ForceMode.Acceleration);
        if (_rigidBody.detectCollisions) return;
    }

}
