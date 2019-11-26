using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawn : MonoBehaviour
{
    private float timerAux;
    public int position { get; private set; }
    public Pool enemyPool { get; private set; }
    [SerializeField]
    private float spawnInterval = 1f;
    

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
        }
    }
}
