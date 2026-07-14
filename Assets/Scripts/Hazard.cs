using UnityEngine;

public class Hazard : MonoBehaviour
{
    // Set up variables
    public AudioClip hazardSound;

    private void OnTriggerEnter2D(Collider2D entity)
    {
        // Is the player touching the hazard
        if (entity.CompareTag("Player"))
        {
            //Play the hazard / death sound and move them back to the beginning
            FindFirstObjectByType<AudioManager>().PlayEffect(hazardSound);

            entity.GetComponent<Respawn>().RespawnPlayer();
        }
    }
}
