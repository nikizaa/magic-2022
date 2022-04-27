using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapRotation : MonoBehaviour
{
    public InputAction rotationInput;
    // Start is called before the first frame update
    void Start()
    {
        rotationInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float input = rotationInput.ReadValue<float>();

        transform.rotation = Quaternion.Euler(0,input,0);
    }
}
