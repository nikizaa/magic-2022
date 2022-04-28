using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapRotation : MonoBehaviour
{
    public float speedMultiplier = 100;
    public InputAction rotationInput;

    // Start is called before the first frame update
    void Start()
    {
        rotationInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float currentInput = rotationInput.ReadValue<float>();

        transform.Rotate(0,currentInput * speedMultiplier * Time.deltaTime,0);
    }
}
