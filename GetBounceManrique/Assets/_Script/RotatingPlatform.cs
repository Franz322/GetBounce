using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 30f; // Degrees per second

    void Update()
    {
        // Rotate around the Z axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
