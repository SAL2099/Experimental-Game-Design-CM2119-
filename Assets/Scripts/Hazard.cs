using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.CompareTag("Player"))
        {
            entity.GetComponent<Respawn>().RespawnPlayer();
        }
    }
}
