using UnityEngine;

public class PlayerPositionScript : MonoBehaviour
{
    float interval = 0.01f; // интервал между выводами 
    private float timer = 0f;
    public static int PlayerPosition;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;

            Vector3 pos = transform.position;

            PlayerPosition = Mathf.RoundToInt(pos.z);

            Debug.Log($"Ваша позиция:{PlayerPosition}");
        }
    }
}
