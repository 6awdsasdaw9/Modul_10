using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    private Rigidbody _rigidBody;


    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
     //   ScoreInfo.ScoreEvent += MassDown();
    }

    

    private void MassDown()
    {
        _rigidBody.mass -= 0.1f;
    }

}
