using UnityEngine;

public class Speen : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around the Z axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}