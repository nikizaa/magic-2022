using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapRotationLandscape : MonoBehaviour
{
    public float speedMultiplier = 100;
    public InputAction rotationInput;

    // Start is called before the first frame update
    void Start()
    {
        rotationInput.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float currentInput = rotationInput.ReadValue<float>();
 
        //transform.rotation = Quaternion.Euler(0,currentInput*360,0);
//        transform.Rotate(0,currentInput * speedMultiplier * Time.deltaTime,0);
        GetComponent<Rigidbody>().AddTorque(0,currentInput * speedMultiplier,0);
    }
}
