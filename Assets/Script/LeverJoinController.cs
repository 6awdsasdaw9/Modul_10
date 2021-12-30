using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverJoinController : MonoBehaviour
{
    [SerializeField] HingeJoint _hingeJoint;
    private JointSpring _jointSpring_Down;
    private JointSpring _jointSpring_Up;

    private void Awake()
    {
        _jointSpring_Down = _hingeJoint.spring;
        _jointSpring_Up = _hingeJoint.spring;
        _jointSpring_Down.targetPosition = 20f;
        _jointSpring_Up.targetPosition = -30f;

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            _hingeJoint.spring = _jointSpring_Up;
        }
       if(Input.GetKeyUp(KeyCode.X))
        {
            _hingeJoint.spring = _jointSpring_Down;
        }
      

    }
}
