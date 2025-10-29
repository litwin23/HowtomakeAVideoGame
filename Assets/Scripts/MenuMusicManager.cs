using UnityEngine;
using UnityEngine.UI;

public class MenuMusicManager : MonoBehaviour
{
    public static MenuMusicManager instance = null;
    public AudioSource musicSource;
    public Image icon;
    public Sprite musicONicon;
    public Sprite musicOFFicon;
    float musicVolume = 0.3f;
    

    MenuMusicManager isMusicOnMenu = new MenuMusicManager();
    public bool isMusicOnMenu
    {
      isMusicOnMenu.bool = true;
    }

    public void ToggleMusic()
    {
        isMusicOnMenu = !isMusicOnMenu;

        if (musicSource != null)
        {
            if (isMusicOnMenu)
            {
                musicSource.volume = musicVolume;
                if (icon != null) icon.sprite = musicONicon;
            }
            else
            {
                musicSource.volume = 0;
                if (icon != null) icon.sprite = musicOFFicon;
                Debug.Log("Переменая bool = " + isMusicOnMenu);
            }
        }

        void Awake()
        {
        
            
            // Настраиваем AudioSource для непрерывного воспроизведения
            if (musicSource != null)
            {
                musicSource.loop = true; // Зацикливаем музыку
                musicSource.playOnAwake = true; // Воспроизводим при создании
                musicSource.volume = isMusicOnMenu ? musicVolume : 0f; // Устанавливаем начальную громкость
                
                
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
    }
}
