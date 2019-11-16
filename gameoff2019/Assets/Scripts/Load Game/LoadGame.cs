using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    int indexScene;

    private void Start()
    {
        indexScene = SceneManager.GetActiveScene().buildIndex;
    }
    public void Play()
    {
        PressetGame();
        SceneManager.LoadScene(indexScene + 1);
    }

    private static void PressetGame()
    {
        PlayerPrefs.SetInt("Coins", 0);

        PlayerPrefs.SetInt("Stage1", 1);
        PlayerPrefs.SetInt("Stage2", 0);
        PlayerPrefs.SetInt("Stage3", 0);
        PlayerPrefs.SetInt("Stage4", 0);
        PlayerPrefs.SetInt("Stage5", 0);
        PlayerPrefs.SetInt("Stage6", 0);
        PlayerPrefs.SetInt("Stage7", 0);
        PlayerPrefs.SetInt("Stage8", 0);
        PlayerPrefs.SetInt("Stage9", 0);
        PlayerPrefs.SetInt("Stage10", 0);

        PlayerPrefs.SetInt("StartedGame", 1);
    }

    public void Continue()
    {
        int startedGame = PlayerPrefs.GetInt("StartedGame");
        if (startedGame > 0)
        {
            SceneManager.LoadScene(indexScene + 1);
        }
    }
}
