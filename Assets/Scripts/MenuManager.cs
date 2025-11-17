using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

public int MenuScene;
public int InfiniteLevel;
public int RestartScene;


    public void ToMenu()
    {
    SceneManager.LoadScene (MenuScene);
    }

    public void ToGame()
    {
    SceneManager.LoadScene (InfiniteLevel);
    }

    public void ExitGame()
    {
    Application.Quit();
    Debug.LogError("Вы покинули игру");
    }

    public void Restart()
    {
    SceneManager.LoadScene (InfiniteLevel);
    }

}
