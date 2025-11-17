using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Obstade;
    public Vector3 spawnValues;
    int spawnCount  ;
    float spawntime = 0.7f;
    float startwait = 0.6f;
    float waitwave = 5;

    private void Start() 
    {
        StartCoroutine(SpawnClon());
    }

    IEnumerator SpawnClon()
    {
            yield return new WaitForSeconds(startwait);
            
            for(float spawnValuesZ = 100; spawnValuesZ <=20000; spawnValuesZ += 100)
            {

                Debug.Log(spawnValuesZ);
                Vector3 spawnPosition = new Vector3(Mathf.Round(Random.Range(-spawnValues.x, spawnValues.x)),spawnValues.y,Mathf.Round(Random.Range(spawnValues.z, spawnValuesZ)));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Obstade, spawnPosition, spawnRotation); 
                yield return new WaitForSeconds(spawntime);

            }
          yield return new WaitForSeconds(waitwave);
    }
}

