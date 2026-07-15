using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector3 spawnPoint;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPoint = transform.position;
    }

    public void RespawnPlayer()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = spawnPoint;
    }
}
