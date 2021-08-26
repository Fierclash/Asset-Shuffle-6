using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Simple host script that will maintain and manage all components of the player
/// </summary>
public class PlayerHost : MonoBehaviour
{
    public Movement3D movement;     // Component that lets the game control how the player moves
    public Rigidbody body;          // Component that enables 3D physics and motion on the player
    public Transform cameraHost;    // Reference the transform that holds the camera

    private Vector3 offset;         // The offset between the player and the camera
    
    // Initialization function that is called when the script is loaded.
    // Inherited by MonoBehaviour.
    void Awake()
    {
        body = GetComponent<Rigidbody>();
        offset = cameraHost.transform.position - transform.position;
    }

    void FixedUpdate()
    {
        cameraHost.transform.position = transform.position + offset;        // Moves the camera to maintain a constant distance from the player
    }
}
