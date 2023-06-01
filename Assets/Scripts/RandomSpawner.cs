using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float spawnTime = 3f;
    public GameObject[] myObjects;

    void Start()
    {
        InvokeRepeating("Spawning", spawnTime, spawnTime);
    }


    void Spawning()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(20, 300), Random.Range(0.5f, 0.6f), Random.Range(-6, 6));

        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
    }
}