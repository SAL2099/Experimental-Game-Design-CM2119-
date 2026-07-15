using UnityEngine;

public class Burn : MonoBehaviour
{
    public AudioClip burnSound;

    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.CompareTag("Player"))
        {
            FindFirstObjectByType<AudioManager>().PlayEffect(burnSound);
        }
    }
}
