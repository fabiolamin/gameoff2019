using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageWin : MonoBehaviour
{
    private ControlChips controlChips;
    private Player player;
    [SerializeField]
    private GameObject canvasWin;

    public int totalEnemies { get; set; }
    
    private void Start()
    {
        player = FindObjectOfType<Player>();
        controlChips = FindObjectOfType<ControlChips>();
    }

    public void CountEnemyDestroyed()
    {
        totalEnemies--;
        Debug.Log("Restantes Enemys: " + totalEnemies);
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
