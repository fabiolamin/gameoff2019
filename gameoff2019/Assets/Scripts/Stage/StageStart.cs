using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageStart : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnEnimies;
    void Start()
    {
        int totalEnemies = 0;
        spawnEnimies = GameObject.FindGameObjectsWithTag("EnemySpawn");
        EnemiesBar enemiesBar = FindObjectOfType<EnemiesBar>();
        enemiesBar.ChangeEnemiesSlideBar(spawnEnimies[0]);
        foreach(GameObject spawnEnemy in spawnEnimies)
        {
            totalEnemies += spawnEnemy.GetComponent<EnemySpawn>().enemyPool.GetInstances();
            spawnEnemy.SetActive(false);
        }

        FindObjectOfType<StageWin>().totalEnemies = totalEnemies;
    }

    public void ActivateSpawnEnemies(GameObject btnStartStage)
    {
        btnStartStage.SetActive(false);
        foreach (GameObject spawnEnemy in spawnEnimies)
        {
            spawnEnemy.SetActive(true);
        }
    }
}
