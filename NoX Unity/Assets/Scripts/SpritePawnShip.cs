using UnityEngine;

public class ShipPawn : MonoBehaviour
{
    [Header("Movement Speeds")]
    public float moveSpeed = 5f;
    public float turboSpeed = 10f;
    public float rotateSpeed = 180f;

    [Header("Teleport Settings")]
    public float worldTeleportDistance = 1f;
    public float randomTeleportRange = 10f;

    public void Move(float amount, bool turbo)
    {
        float speed = turbo ? turboSpeed : moveSpeed;

        transform.position +=
            transform.up * amount * speed * Time.deltaTime;
    }

    public void Rotate(float amount)
    {
        transform.Rotate(
            0,
            0,
            -amount * rotateSpeed * Time.deltaTime);
    }

    public void WorldTeleport(Vector2 direction)
    {
        transform.position +=
            (Vector3)(direction.normalized * worldTeleportDistance);
    }

    public void RandomTeleport()
    {
        float randomX = Random.Range(
            -randomTeleportRange,
            randomTeleportRange);

        float randomY = Random.Range(
            -randomTeleportRange,
            randomTeleportRange);

        transform.position = new Vector3(
            randomX,
            randomY,
            transform.position.z);
    }
}