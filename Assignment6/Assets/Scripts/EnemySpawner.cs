/*
 * Gerard Lamoureux
 * EnemySpawner
 * Assignment 6
 * Handles the Enemy Spawn System
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyFactory enemyFactory = new NormalEnemyFactory();

    public List<string> enemyTypes = new List<string>();

    private int enemiesSpawned = 0;

    public int maxEnemiesToSpawn = 10;

    public float spawnRate = 1;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
        UpdateFactory();
    }

    public void UpdateFactory()
    {
        int score = GameManager.gameManager.PlayerScore;
        if(score < maxEnemiesToSpawn)
        {
            if (enemyFactory.factoryType != "NormalEnemyFactory")
            {
                GameManager.gameManager.GameWave = 1;
                enemiesSpawned = 0;
                enemyFactory = new NormalEnemyFactory();
            }
        }
        else if(score < maxEnemiesToSpawn * 2)
        {
            if(enemyFactory.factoryType != "EliteEnemyFactory")
            {
                GameManager.gameManager.GameWave = 2;
                enemiesSpawned = 0;
                enemyFactory = new EliteEnemyFactory();
            }
        }
        else if(score < maxEnemiesToSpawn * 3)
        {
            if(enemyFactory.factoryType != "SuperEnemyFactory")
            {
                GameManager.gameManager.GameWave = 3;
                enemiesSpawned = 0;
                enemyFactory = new SuperEnemyFactory();
            }
        }
        else if(score < maxEnemiesToSpawn * 4)
        {
            GameManager.gameManager.GameIsOver(true);
        }
    }

    private IEnumerator SpawnEnemies()
    {
        string enemyType;
        GameObject prefab;
        while(!GameManager.gameManager.gameOver)
        {
            UpdateFactory();
            if(enemiesSpawned < maxEnemiesToSpawn)
            {
                enemyType = enemyTypes[Random.Range(0, enemyTypes.Count)];
                prefab = enemyFactory.CreateEnemyPrefab(enemyType);
                prefab = Instantiate(prefab, new Vector3(-12f, Random.Range(-4,4), 0), Quaternion.identity);
                enemyFactory.AddEnemyScript(prefab, enemyType);
                enemiesSpawned++;
            }
            yield return new WaitForSeconds(spawnRate);
        }
        yield return null;
    }
}
