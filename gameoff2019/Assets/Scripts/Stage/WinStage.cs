using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinStage : MonoBehaviour
{
    [SerializeField]
    private GameObject canvasWin;

    private int totalEnemies;
    private int totalEnemiesDestoyed;
    private ControlChips controlChips;
    private Player player;
    

    private void Start()
    {
        player = FindObjectOfType<Player>();
        controlChips = FindObjectOfType<ControlChips>();
        totalEnemiesDestoyed = 0;
        totalEnemies = 0;
        EnemySpawn[] enemySpawns = FindObjectsOfType<EnemySpawn>();
        foreach(EnemySpawn eS in enemySpawns)
        {
            totalEnemies += eS.enemyPool.GetInstances();
        }
        Debug.Log("Total Enemys: " + totalEnemies);
    }

    public void CountEnemyDestroyed()
    {
        totalEnemies--;
        Debug.Log("Restantes Enemys: " + totalEnemies); //to do
        if (totalEnemies<=0 && !controlChips.gameOver)
        {
            SaveStage();
            canvasWin.SetActive(true);
        }
    }

    private void SaveStage()
    {
        int coins = player.Coins;
        PlayerPrefs.SetInt("Coins", coins);

        string nameScene = SceneManager.GetActiveScene().name;
        switch (nameScene)
        {
            case "Stage1":
                SetStage("Stage1","Stage2");
                break;
            case "Stage2":
                SetStage("Stage2", "Stage3");
                break;
            case "Stage3":
                SetStage("Stage3", "Stage4");
                break;
            case "Stage4":
                SetStage("Stage4", "Stage5");
                break;
            case "Stage5":
                SetStage("Stage5", "Stage6");
                break;
            case "Stage6":
                SetStage("Stage6", "Stage7");
                break;
            case "Stage7":
                SetStage("Stage7", "Stage8");
                break;
            case "Stage8":
                SetStage("Stage8", "Stage9");
                break;
            case "Stage9":
                SetStage("Stage9", "Stage10");
                break;
            case "Stage10":
                PlayerPrefs.SetInt("Stage10", 0);
                break;
        }


    }

    private void SetStage(string stageNow, string nextStage)
    {
        PlayerPrefs.SetInt(stageNow, 0);
        PlayerPrefs.SetInt(nextStage, 1);
    }
}
