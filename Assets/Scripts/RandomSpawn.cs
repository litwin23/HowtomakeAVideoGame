// Подключаем Unity Engine для работы с игровыми объектами
using UnityEngine;

// Создаем публичный класс для спавна объектов по тегу
public class RandomSpawn : MonoBehaviour
{
    // Публичная переменная для хранения префаба объекта, который будем спавнить
    public GameObject Obstade;
    // Публичная переменная для хранения значений спавна (пока не используется)
    public Vector3 spawnValies;
    // Публичная переменная для указания количества объектов для создания (по умолчанию 5)
    public short spawnCount = 1000; // Количество объектов для спавна
    
    // Публичная переменная для минимального расстояния между объектами
    public float minDistanceBetweenObjects = 4.0f;
    
    // Приватная переменная для хранения позиций уже созданных объектов
    private System.Collections.Generic.List<Vector3> spawnedPositions = new System.Collections.Generic.List<Vector3>();
    
    // Заголовок в Unity Inspector для группировки координат
    [Header("Координаты спавна")]
    // Публичная переменная для минимальных координат спавна (X=-10, Y=0.8, Z=40)
    public Vector3 minCoordinates = new Vector3(-5, 0.8f, 40); // Минимальные координаты
    // Публичная переменная для максимальных координат спавна (пока не используется)
    public Vector3 maxCoordinates = new Vector3(5, 0.8f,20000);

    // Метод Start вызывается Unity автоматически при запуске игры
    void Start()
    {
        // Вызываем метод спавна объектов при старте игры
        SpawnMaves();
    }

    // Основной метод для запуска процесса спавна
    void SpawnMaves()
    {
        // Запускаем рекурсивный метод создания объектов, начиная с 0
        SpawnMultipleObjects(0);
    }
    
    // Рекурсивный метод для создания нескольких объектов без использования циклов
    void SpawnMultipleObjects(int currentCount)
    {
        // Проверяем, создали ли мы уже достаточно объектов
        if (currentCount >= spawnCount)
        {
            // Если да, то выходим из метода (базовый случай рекурсии)
            return;
        }
        
        // Пытаемся найти подходящую позицию для спавна
        Vector3 spawnPosition = FindValidSpawnPosition();
        
        // Если нашли подходящую позицию
        if (spawnPosition != Vector3.zero)
        {
            // Добавляем позицию в список
            spawnedPositions.Add(spawnPosition);
            
            // Создаем переменную для поворота объекта (без поворота)
            Quaternion spawnRotation = Quaternion.identity;
            // Создаем новый объект в указанной позиции с указанным поворотом
            Instantiate(Obstade, spawnPosition, spawnRotation);
            
            // Рекурсивно вызываем этот же метод для создания следующего объекта
            SpawnMultipleObjects(currentCount + 1);
        }
        else
        {
            // Если не удалось найти подходящую позицию, завершаем спавн
            Debug.LogWarning(" удалось найти подходящую позицию для спавна объекта " + currentCount);
            return;
        }
    }
    
    // Метод для поиска подходящей позиции с учетом минимального расстояния
    Vector3 FindValidSpawnPosition()
    {
        int maxAttempts = 100; // Максимальное количество попыток поиска позиции
        
        for (int attempt = 0; attempt < maxAttempts; attempt++)
        {
            // Создаем случайную позицию
            float randomX = Random.Range(minCoordinates.x, maxCoordinates.x);
            float randomZ = Random.Range(minCoordinates.z, maxCoordinates.z);
            Vector3 candidatePosition = new Vector3(randomX, minCoordinates.y, randomZ);
            
            // Проверяем, подходит ли эта позиция (расстояние от других объектов)
            if (IsPositionValid(candidatePosition))
            {
                return candidatePosition;
            }
        }
        
        // Если не нашли подходящую позицию за 100 попыток, возвращаем нулевую позицию
        return Vector3.zero;
    }
    
    // Метод для проверки, подходит ли позиция (достаточное расстояние от других объектов)
    bool IsPositionValid(Vector3 position)
    {
        // Проверяем расстояние от всех уже созданных объектов
        foreach (Vector3 existingPosition in spawnedPositions)
        {
            float distance = Vector3.Distance(position, existingPosition);
            if (distance < minDistanceBetweenObjects)
            {
                return false; // Слишком близко к существующему объекту
            }
        }
        return true; // Позиция подходит
    }
        
}
