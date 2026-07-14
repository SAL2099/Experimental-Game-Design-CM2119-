using UnityEngine;

public class Wood : MonoBehaviour
{
    public AudioClip woodSound;

    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.CompareTag("Player"))
        {
            FindFirstObjectByType<AudioManager>().PlayEffect(woodSound);
        }
    }
}
