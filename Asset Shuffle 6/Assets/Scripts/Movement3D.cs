using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Simple movement class for 3D objects
/// </summary>
public class Movement3D : MonoBehaviour
{
    public float baseSpeed = 5f;    // Determines the speed of the object

    // Moves the object with a given force factor
    public void Move(Rigidbody body, Vector3 direction, float force)
    {
        body.AddForce(direction.normalized * force);
    }

    // Moves the object using the object's baseSpeed variable
    public void Move(Rigidbody body, Vector3 direction) =>
        Move(body, direction, baseSpeed);
}
