using UnityEngine;
using UnityEngine.UI;

public class MenuMusicManager : MonoBehaviour
{
    //ресурсы звука
    public AudioSource musicSource;
    public AudioClip clip;
    //Sprite кнопки
    public Sprite musicOnIcon;
    public Sprite musicOffIcon;
    //кнопка
    public GameObject MenuButtonMusic;
    //слайдр
    public Slider MusicSlider;
    //переменая звука
    public static float VolumeMainMusic;


    void Update()
    {
        VolumeMainMusic = MusicSlider.value;
        musicSource.volume = VolumeMainMusic;
    }

    public void OnOffAudio()
    {
        if (MusicSlider.value == 1)
        {
            AudioListener.volume = 0;
            MenuButtonMusic.GetComponent<Image>().sprite = musicOffIcon;
        }

        if (MusicSlider.value == 0)
        {
            AudioListener.volume = 1;
            MenuButtonMusic.GetComponent<Image>().sprite = musicOnIcon;
        }

        if (AudioListener.volume > 0)
        {
            MusicSlider.value = 0;
        }
    }

    public void PlaySound()
    {
        musicSource.PlayOneShot(clip);
    }
}