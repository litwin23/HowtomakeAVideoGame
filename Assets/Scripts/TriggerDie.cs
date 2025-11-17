using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDie : MonoBehaviour
{

    void Start()
    {
        
    }

    void OnTriggerExit(Collider col)
    {
        if(col)
        {
            SceneManager.LoadScene ("Main Restart");
        }
    }
}