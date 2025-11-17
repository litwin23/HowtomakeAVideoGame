using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    private int PlPos;
    public TextMeshProUGUI textpro;


    void Start()
    {
    PlPos = PlayerPositionScript.PlayerPosition;
    textpro.text = "You Score :" + PlPos;
    }

}
