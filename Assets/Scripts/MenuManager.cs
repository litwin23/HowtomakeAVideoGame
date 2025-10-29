using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

public int menuScene;
public int InfiniteLevel;
public int DefeatScene;


    public void ToMenu()
    {
    SceneManager.LoadScene (menuScene);
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

}
