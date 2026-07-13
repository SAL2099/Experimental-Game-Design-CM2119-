using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundSource; //Background music
    public AudioSource effectsSource; //Sound effecs

    public void PlayBackground(AudioClip clip)
    {
        backgroundSource.clip = clip;
        backgroundSource.loop = true;
        backgroundSource.Play();
    }

    public void PlayEffect(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

  
}
