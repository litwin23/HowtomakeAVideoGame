using UnityEngine;
using UnityEngine.UI;

public class GameMusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip clip;

    void Update()
    {
        musicSource.volume = MenuMusicManager.VolumeMainMusic;
    }

    void ToggleMusic()
    {
    }
       
    public void PlaySound()
    {
        musicSource.PlayOneShot(clip);
    }
} 


