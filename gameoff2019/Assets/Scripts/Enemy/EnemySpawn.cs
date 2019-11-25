using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    private float timerAux;
    private int position;
    private Pool enemyPool;
    [SerializeField]
    private float spawnInterval = 1f;
    [SerializeField]
    private Slider slideBarEnemies;

    public float SpawnInterval
    {
        get { return spawnInterval; }
        private set { spawnInterval = value; }
    }

    private void Awake()
    {
        timerAux = spawnInterval;
        position = 0;
        enemyPool = GetComponent<Pool>();
        slideBarEnemies.maxValue = enemyPool.GetInstances();
        slideBarEnemies.value = position;
    }
    private void Update()
    {
        timerAux -= Time.deltaTime;
        if (timerAux < 0)
        {
            Spawn();
            timerAux = spawnInterval;
        }
    }
    void Spawn()
    {
        if (position <= enemyPool.InstantiatePrefabs.Length - 1)
        {
            enemyPool.ChangePrefabStatus(position, true);
            position++;
            slideBarEnemies.value = position;
        }
    }
}
