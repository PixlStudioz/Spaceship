using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        // Horizontal movement
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        // Vertical movement
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        // Create movement vector
        Vector3 movement = new Vector3(moveX, moveY, 0f);

        // Move the object
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}