using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePhysics : MonoBehaviour
{
    public GameObject disconnectObject;

    public void Fall(){

        ConfigurableJoint joint = disconnectObject.GetComponent<ConfigurableJoint>();
        Destroy(joint);


        ConfigurableJoint[] joints = GetComponentsInChildren<ConfigurableJoint>();

        for(int i = 0; i < joints.Length; i++)
        {
            joints[i].breakForce = 50;
            joints[i].breakTorque = 50;
        }
    }
}
