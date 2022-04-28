using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapRotation : MonoBehaviour
{
    public float speedMultiplier = 100;
    float startInput;
    public InputAction rotationInput;
    bool firstUpdateComplete;

    // Start is called before the first frame update
    void Start()
    {
        rotationInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float rawInput = rotationInput.ReadValue<float>();
        if(!firstUpdateComplete){
             startInput = rawInput;
            firstUpdateComplete = true;
        }

        float currentInput = rawInput - startInput;

        transform.Rotate(0,currentInput * speedMultiplier * Time.deltaTime,0);
    }
}
