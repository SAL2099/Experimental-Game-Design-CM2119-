using UnityEngine;

public class Birds : MonoBehaviour
{

    public AudioClip birdSound;

    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.CompareTag("Player"))
        {
            FindFirstObjectByType<AudioManager>().PlayEffect(birdSound);
        }
    }
}