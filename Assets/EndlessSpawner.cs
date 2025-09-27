using UnityEngine;
using System.Collections.Generic;

public class EndlessSpawner : MonoBehaviour
{
    [Header("Настройки спавна")]
    public GameObject spawnSurface;       // Объект для спавна
    public Transform player;          // Ссылка на игрока
    public float spawnDistance = 30f;  // На каком расстоянии впереди игрока спавнить
    public float removeDistance = 20f; // На каком расстоянии позади игрока удалять
    public int maxObjects = 20;       // Максимальное количество одновременно

    private List<GameObject> spawned = new List<GameObject>();

    void Update()
    {
        if (spawnSurface == null || player == null) return;

        // ✅ Спавн впереди игрока, пока меньше лимита
        while (spawned.Count < maxObjects)
        {
            Vector3 forwardPos = player.position + 
                                 player.forward * (spawnDistance + Random.Range(-5f,5f));
            forwardPos.x += Random.Range(-5f, 5f); // разброс по X
            forwardPos.z += Random.Range(-5f, 5f); // разброс по Z

            GameObject obj = Instantiate(spawnSurface, forwardPos, Quaternion.identity);
            spawned.Add(obj);
        }

        // ✅ Удаляем те, что слишком далеко позади игрока
        for (int i = spawned.Count - 1; i >= 0; i--)
        {
            GameObject obj = spawned[i];
            if (Vector3.Distance(player.position, obj.transform.position) > spawnDistance + removeDistance)
            {
                Destroy(obj);
                spawned.RemoveAt(i);
            }
        }
    }
}
