using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Obstade;
    public Vector3 spawnValues;
    public int spawnCount;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstade")
        {
            for(int i = 0; i < spawnCount; i++)

            {

            Vector3 spawnPosition = new Vector3(Mathf.Round(Random.Range(-spawnValues.x, spawnValues.x)),spawnValues.y,spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(Obstade, spawnPosition, spawnRotation); 

            }
        }
        else
        {

        }
    }
}
