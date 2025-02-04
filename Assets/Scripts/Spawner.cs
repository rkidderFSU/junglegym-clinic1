using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> spawnPoints;
    public GameObject enemyPrefab;
    GameObject[] enemies;
    int enemiesRemaining;
    public int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(spawnCount));
    }

    // Update is called once per frame
    void Update()
    {
        TrackEnemies();
    }

    IEnumerator SpawnEnemy(int numberToSpawn)
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            int randomNumber = Random.Range(0, spawnPoints.Count);
            GameObject randomSpawnPoint = spawnPoints[randomNumber];
            Instantiate(enemyPrefab, randomSpawnPoint.transform);
        }
        yield return null;
    }

    void TrackEnemies()
    {
        // Find out how many enemies there are
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesRemaining = enemies.Length;
        // If there are no enemies, spawn some more
        if (enemiesRemaining == 0)
        {
            StartCoroutine(SpawnEnemy(spawnCount));
        }
    }
}