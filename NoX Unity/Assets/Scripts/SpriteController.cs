using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ShipPawn pawn;

    private void Update()
    {
        bool turbo =
            Input.GetKey(KeyCode.LeftShift) ||
            Input.GetKey(KeyCode.RightShift);

        float moveInput = 0f;
        float rotateInput = 0f;

        if (Input.GetKey(KeyCode.W))
            moveInput = 1f;

        if (Input.GetKey(KeyCode.S))
            moveInput = -1f;

        if (Input.GetKey(KeyCode.A))
            rotateInput = -1f;

        if (Input.GetKey(KeyCode.D))
            rotateInput = 1f;

        pawn.Move(moveInput, turbo);
        pawn.Rotate(rotateInput);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            pawn.WorldTeleport(Vector2.up);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            pawn.WorldTeleport(Vector2.down);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            pawn.WorldTeleport(Vector2.left);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            pawn.WorldTeleport(Vector2.right);

        if (Input.GetKeyDown(KeyCode.T))
            pawn.RandomTeleport();
    }
}