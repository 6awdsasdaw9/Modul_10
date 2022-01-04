using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private float _defaulMass;


    public Rigidbody Rigidbody { get =>_rigidBody; }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        
     //   ScoreInfo.ScoreEvent += MassDown();
    }

    

    public void MassDown()
    {
      if(_rigidBody.mass > 3) _rigidBody.mass -= 0.1f;
    }

}
