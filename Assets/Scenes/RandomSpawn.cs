using UnityEngine;

public class CloneByTagSpawner : MonoBehaviour
{
    [Header("Настройки")]
    public GameObject spawnSurface;   // Объект-платформа
    public string targetTag; // Тег объекта-образца
    int cloneCount = 200;      // Сколько клонов создать
    public float yOffset = 0.8f;      // Поднять над поверхностью

    void Start()
    {
        if (spawnSurface == null)
        {
            Debug.LogError("❗ Укажи платформу для спавна");
            return;
        }

        // Находим первый объект с нужным тегом — он станет шаблоном
        GameObject template = GameObject.FindWithTag(targetTag);
        if (template == null)
        {
            Debug.LogError($"❗ Не найден объект с тегом {targetTag}");
            return;
        }

        Collider surfaceCollider = spawnSurface.GetComponent<Collider>();
        if (surfaceCollider == null)
        {
            Debug.LogError("❗ На платформе должен быть Collider");
            return;
        }

        Bounds bounds = surfaceCollider.bounds;


         if (cloneCount > 0 && cloneCount <= 300)
    {
        for (int i = 0; i < cloneCount; i++)
        {
            float randomX = Random.Range(bounds.min.x, bounds.max.x);
            float randomZ = Random.Range(bounds.min.z, bounds.max.z);
            Vector3 spawnPos = new Vector3(randomX, bounds.max.y + yOffset, randomZ);

                Instantiate(template, spawnPos, Quaternion.identity);
        }
    }
            
}
    void Update()
     {
        Debug.Log("ee");
        
    }
}
