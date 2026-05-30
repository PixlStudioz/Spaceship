using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteScaler : MonoBehaviour
{
    public float maxScale = 1f;

    void Update()
    {
        float scaleAmount = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            scaleAmount = maxScale * Time.deltaTime;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            scaleAmount = -maxScale * Time.deltaTime;
        }

        transform.localScale += Vector3.one * scaleAmount;
    }
}