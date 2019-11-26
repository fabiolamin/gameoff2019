using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarEnemies : MonoBehaviour
{
    [SerializeField]
    private Slider slideBarEnemies;
    private EnemySpawn enemySpawn;
    private GameObject goEnemySpawn;

    public void SetEnemySpawn(GameObject eS) {
        goEnemySpawn = eS;
        enemySpawn = eS.GetComponent<EnemySpawn>();
        slideBarEnemies.maxValue = enemySpawn.enemyPool.GetInstances();
        slideBarEnemies.value = enemySpawn.position;
    }

    void Update()
    {
        if(goEnemySpawn!=null && goEnemySpawn.activeSelf)
        {
            slideBarEnemies.value = enemySpawn.position;
        }
    }
}
