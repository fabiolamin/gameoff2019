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
                break;
            case 3:
                LoadStage("Stage2", stageIndexScene);
                break;
            case 5:
                LoadStage("Stage3", stageIndexScene);
                break;
            case 6:
                LoadStage("Stage4", stageIndexScene);
                break;
            case 7:
                LoadStage("Stage5", stageIndexScene);
                break;
            case 8:
                LoadStage("Stage6", stageIndexScene);
                break;
            case 9:
                LoadStage("Stage7", stageIndexScene);
                break;
            case 10:
                LoadStage("Stage8", stageIndexScene);
                break;
            case 11:
                LoadStage("Stage9", stageIndexScene);
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
