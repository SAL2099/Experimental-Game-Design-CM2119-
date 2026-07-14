using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Polaroid : MonoBehaviour
{
    // Setting up variables
    private bool polaroidRange;

    public AudioClip polaroidSound; 

    [SerializeField]
    private GameObject polaroidCanvas;

    [SerializeField]
    private Image polaroidImage;

    [SerializeField]
    private TMP_Text polaroidText;

    [SerializeField]
    private Image polaroids;

    [SerializeField]
    [TextArea]
    private string polaroidDescription;



    // Update is called once per frame
    void Update()
    {
        // Is the player pressing the interact button while within range of the polaroid
        if (Input.GetButtonDown("Interact") && polaroidRange == true)
        {
            // Play sound, show canvas and display correct image and text for that polaroid
            FindFirstObjectByType<AudioManager>().PlayEffect(polaroidSound);
            polaroidCanvas.SetActive(true);
            polaroidImage = polaroids;
            polaroidImage.gameObject.SetActive(true);
            polaroidText.text = polaroidDescription;
        }
    }

    // Is the polaroid touching the player?
    private void OnTriggerEnter2D(Collider2D entity)
    {
        if(entity.gameObject.tag == "Player")
        {
            polaroidRange = true;
        }
    }

    // Polaroid is no longer touching player
    private void OnTriggerExit2D(Collider2D entity)
    {
        polaroidRange = false;
        polaroidCanvas.SetActive(false);
        polaroidImage.gameObject.SetActive(false);
    }
}
