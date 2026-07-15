using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Lets you set the audio sources
    public AudioSource backgroundSource; //Background music
    public AudioSource effectsSource; //Sound effecs

    // Plays the nackground music
    public void PlayBackground(AudioClip clip)
    {
        backgroundSource.clip = clip;
        backgroundSource.loop = true;
        backgroundSource.Play();
    }

    // Plays sound effects
    public void PlayEffect(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

  
}
