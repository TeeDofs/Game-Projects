using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float minSpawnTime = 2f;
    public float maxSpawnTime = 4f;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(spawnPrefab, transform.position, Quaternion.identity);
        Invoke(nameof(Spawn), Random.Range(minSpawnTime, maxSpawnTime));
    }
}
