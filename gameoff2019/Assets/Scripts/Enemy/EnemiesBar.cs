using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemiesBar : MonoBehaviour
{
    [SerializeField]
    private Slider slideBarEnemies;
    private EnemySpawn enemySpawn;

    void Update()
    {
        if (enemySpawn.gameObject != null && enemySpawn.gameObject.activeSelf)
        {
            slideBarEnemies.value = enemySpawn.position;
        }
    }

    public void ChangeEnemiesSlideBar(GameObject enemySpawnGameObject) {
        enemySpawn = enemySpawnGameObject.GetComponent<EnemySpawn>();
        slideBarEnemies.maxValue = enemySpawn.enemyPool.GetInstances();
        slideBarEnemies.value = enemySpawn.position;
    }
}
