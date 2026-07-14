using UnityEngine;

public class LevelChanger : MonoBehaviour
{

    private bool interactRange;

    [SerializeField]
    private GameObject levelChange;

    // Update is called once per frame
    void Update()
    {
        // Is the player pressing the interact button while within range of the polaroid
        if (interactRange == true)
        {
            levelChange.SetActive(true);
        }
    }

    // Is the polaroid touching the player?
    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.gameObject.tag == "Player")
        {
            interactRange = true;
        }
    }

    // Polaroid is no longer touching player
    private void OnTriggerExit2D(Collider2D entity)
    {
        interactRange = false;
        levelChange.SetActive(false);

    }
}
