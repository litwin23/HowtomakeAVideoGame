using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public float interval = 0.1f; // интервал между выводами (в секундах)
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;

            Vector3 pos = transform.position;

            int z = Mathf.RoundToInt(pos.z);

            Debug.Log($"Ваша позиция:{z}");
        }
    }
}
