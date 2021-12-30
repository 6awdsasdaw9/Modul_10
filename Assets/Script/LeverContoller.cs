using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverContoller : MonoBehaviour
{

    [SerializeField] private KeyCode _concreteKey;
    bool up = false;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {
         transform.rotation = Quaternion.Euler(0, 0, 60);
            
        }
        else
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 120);
            
        }

        //if(up && transform.rotation == Quaternion.Euler(0,0,60))
        //{
        //    transform.Rotate(0, 0, 30);
        //    up = false; 
        //}
    }

}
