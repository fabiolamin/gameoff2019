using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStage : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnEnimies;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnimies = GameObject.FindGameObjectsWithTag("EnemySpawn");
        BarEnemies barEnemies = FindObjectOfType<BarEnemies>();
        barEnemies.SetEnemySpawn(spawnEnimies[0]);
        foreach(GameObject go in spawnEnimies)
        {
            go.SetActive(false);
        }
        
    }

    public void StartSpawnEnemies(GameObject btnStartStage)
    {
        btnStartStage.SetActive(false);
        foreach (GameObject go in spawnEnimies)
        {
            go.SetActive(true);
        }
    }
}
