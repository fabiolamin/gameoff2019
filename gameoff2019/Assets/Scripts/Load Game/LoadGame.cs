using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    [SerializeField]
    GameObject transitionLoading;
    int indexScene;

    private void Start()
    {
        transitionLoading.SetActive(false);
        indexScene = SceneManager.GetActiveScene().buildIndex;
    }
    public void Play()
    {
        PressetGame();
        transitionLoading.SetActive(true);
        Invoke("LoadMain", 3);
    }

    private void LoadMain()
    {
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

        PlayerPrefs.SetInt("BasicTowerA", 1);
        PlayerPrefs.SetInt("BasicTowerB", 1);
        PlayerPrefs.SetInt("BasicTowerC", 1);
        PlayerPrefs.SetInt("MiddleTowerA", 0);
        PlayerPrefs.SetInt("MiddleTowerB", 0);
        PlayerPrefs.SetInt("MiddleTowerC", 0);
        PlayerPrefs.SetInt("MiddleTowerD", 0);
        PlayerPrefs.SetInt("StrongTowerA", 0);
        PlayerPrefs.SetInt("StrongTowerB", 0);
        PlayerPrefs.SetInt("StrongTowerC", 0);

        PlayerPrefs.SetInt("StartedGame", 1);
    }

    public void Continue()
    {
        int startedGame = PlayerPrefs.GetInt("StartedGame");
        if (startedGame > 0)
        {
            transitionLoading.SetActive(true);
            Invoke("LoadMain", 3);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
