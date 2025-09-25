using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    void Update()
    {
        // Получаем позицию игрока
        Vector3 ps = transform.position;

        // Выводим в консоль
        Debug.Log("Ваша позиция: " + ps);
    }
}
