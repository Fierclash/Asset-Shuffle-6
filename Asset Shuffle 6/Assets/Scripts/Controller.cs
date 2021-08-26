using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Simple controller script that detects player input to perform actions
/// </summary>
public class Controller : MonoBehaviour
{
    private PlayerHost host;        // The host script that will perform actions for the player body

    // Initialization function that is called when the script is loaded.
    // Inherited by MonoBehaviour.
    // [TIP] For classes that inherit from MonoBehaviour, you cannot use constructors:
    // Use either void Awake(), void Start(), or void OnEnable() for any initialization
    void Awake()
    {
        host = GetComponent<PlayerHost>();
    }

    // Update function that is called each frame.
    // Inherited by MonoBehaviour.
    void FixedUpdate()
    {
        host.movement.Move(host.body, GetMovementInput());
    }

    // Generates a Vector3 that refer to the current input state from the player
    private Vector3 GetMovementInput()
    {
        /*  
         *  Vector3 Movement works as follows (assuming facing forward):
         *  x: Left/Right           (A/D)
         *  y: Up/Down
         *  z: Forward/Backward     (W/S)
         */ 
        return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    }
}
