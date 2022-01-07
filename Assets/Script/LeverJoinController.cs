using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverJoinController : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;
    [SerializeField] private KeyCode _key;
    private JointSpring _jointSpring_Down;
    private JointSpring _jointSpring_Up;

    private void Awake()
    {
        _jointSpring_Down = _hingeJoint.spring;
        _jointSpring_Up = _hingeJoint.spring;
        _jointSpring_Down.targetPosition = 20f;
        _jointSpring_Up.targetPosition = -30f;
        _hingeJoint.spring = _jointSpring_Down;

    }

    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            _hingeJoint.spring = _jointSpring_Up;
        }
        if (Input.GetKeyUp(_key))
        {
            _hingeJoint.spring = _jointSpring_Down;
        }
    }

}
