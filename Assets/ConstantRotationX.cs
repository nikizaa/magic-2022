using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotationX : MonoBehaviour
{
    public float speed = 40;
    void Update()
    {
        transform.Rotate(0,0,speed * Time.deltaTime/2);
    }
}
