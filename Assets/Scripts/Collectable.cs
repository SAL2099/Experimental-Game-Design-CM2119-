using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value = 1;

    private bool interactRange;

    void Update()
    {
        // Is the player pressing the interact button while within range of the collectable?
        if (Input.GetButtonDown("Interact") && interactRange == true)
        {
            // Increase counter / score and delete collectable 
            GameManager gm = FindFirstObjectByType<GameManager>();
            gm.AddScore(value);
            Destroy(gameObject);
        }
    }

    // Is the collectable touching the player?
    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.gameObject.tag == "Player")
        {
            interactRange = true;
        }
    }

}
