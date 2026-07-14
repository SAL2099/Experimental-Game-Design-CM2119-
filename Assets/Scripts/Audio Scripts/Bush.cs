using UnityEngine;

public class Bush : MonoBehaviour
{

    public AudioClip bushSound;

    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.CompareTag("Player"))
        {  
            FindFirstObjectByType<AudioManager>().PlayEffect(bushSound);
        }
    }
}
