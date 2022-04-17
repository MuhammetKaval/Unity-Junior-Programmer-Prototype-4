using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRange = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        

        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateSpawnPosition()
    {
        float rangePosX = Random.Range(-spawnRange, spawnRange);
        float rangePosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(rangePosX, 0, rangePosZ);
        return randomPos;
    }
}
