using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStage : MonoBehaviour
{
    [SerializeField]
    GameObject spawnEnimies;
    // Start is called before the first frame update
    void Start()
    {
        BarEnemies barEnemies = FindObjectOfType<BarEnemies>();
        barEnemies.SetEnemySpawn(spawnEnimies);
        spawnEnimies.SetActive(false);
    }

    public void StartSpawnEnemies(GameObject btnStartStage)
    {
        btnStartStage.SetActive(false);
        spawnEnimies.SetActive(true);
    }
}
