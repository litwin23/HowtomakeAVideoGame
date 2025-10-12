using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

public int menuScene;
public int InfiniteLevel;
public int looseScene;
public int getcheat;

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
    }

}
