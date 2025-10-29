using UnityEngine;
using UnityEngine.UI;

public class GameMusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    public float musicVolume;
    private MenuMusicManager isMusicOnMenu;

    
    void Awake()
    {
        // Настраиваем AudioSource для непрерывного воспроизведения
      if (isMusicOnMenu)
        {
                if (musicSource != null)
                {
                    musicSource.loop = true; // Зацикливаем музыку
                    musicSource.playOnAwake = true; // Воспроизводим при создании
                    musicSource.volume = isMusicOnMenu ? musicVolume : 0f; // Устанавливаем начальную громкость
                    Debug.Log("Переменая bool = " + isMusicOnMenu);
                    
                    
                    // Принудительно запускаем музыку
                    if (isMusicOnMenu && musicSource.clip != null)
                    {
                        musicSource.Play();
                        
                    }
                }
            // Гарантируем, что в сцене есть хотя бы один AudioListener
            if (FindObjectOfType<AudioListener>() == null)
            {
                gameObject.AddComponent<AudioListener>();
            
            }
        }
        else
        {
            musicSource.loop = false;
            musicSource.playOnAwake = false;
            Debug.Log("Переменая bool = " + isMusicOnMenu);
            musicSource.volume = 0f; 
        }

    }
} 


