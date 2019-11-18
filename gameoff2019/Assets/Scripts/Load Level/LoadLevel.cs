using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    private int stageIndexScene;

    private void OnMouseDown()
    {
        switch (stageIndexScene)
        {
            case 2:
                LoadStage("Stage1", stageIndexScene);
                PlayerPrefs.SetInt("BasicTowerA", 1);
                PlayerPrefs.SetInt("BasicTowerB", 1);
                PlayerPrefs.SetInt("BasicTowerC", 1);
                break;
            case 3:
                LoadStage("Stage2", stageIndexScene);
                break;
            case 5:
                LoadStage("Stage3", stageIndexScene);
                break;
            case 6:
                LoadStage("Stage4", stageIndexScene);
                PlayerPrefs.SetInt("MiddleTowerA", 1);
                break;
            case 7:
                LoadStage("Stage5", stageIndexScene);
                PlayerPrefs.SetInt("MiddleTowerB", 1);
                break;
            case 8:
                LoadStage("Stage6", stageIndexScene);
                PlayerPrefs.SetInt("MiddleTowerC", 1);
                PlayerPrefs.SetInt("MiddleTowerD", 1);
                break;
            case 9:
                LoadStage("Stage7", stageIndexScene);
                PlayerPrefs.SetInt("StrongTowerA", 1);
                break;
            case 10:
                LoadStage("Stage8", stageIndexScene);
                break;
            case 11:
                LoadStage("Stage9", stageIndexScene);
                PlayerPrefs.SetInt("StrongTowerB", 1);
                PlayerPrefs.SetInt("StrongTowerC", 1);
                break;
            case 12:
                LoadStage("Stage10", stageIndexScene);
                break;
        }
    }  

    private static void LoadStage(string stage, int sceneIndex)
    {
        if (PlayerPrefs.GetInt(stage) > 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
