using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    [SerializeField]
    GameObject transitionLoading;
    [SerializeField] 
    GameObject canvasCredits;
    [SerializeField] 
    GameObject canvasSettigs;
    [SerializeField]
    GameObject audioAmbient;
    [SerializeField]
    GameObject[] audioEffect;
    [SerializeField]
    GameObject menu;
    int indexScene;

    private void Start()
    {
        transitionLoading.SetActive(false);
        indexScene = SceneManager.GetActiveScene().buildIndex;
        if (!(PlayerPrefs.GetInt("FirstPlay") > 0))
        {
            float volume = audioAmbient.GetComponent<AudioSource>().volume;
            PlayerPrefs.SetFloat("VolumeMusic", volume);
            PlayerPrefs.SetFloat("VolumeEffects", volume);
            PlayerPrefs.SetInt("FirstPlay", 1);
        }
        else
        {
            audioAmbient.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumeMusic");
            audioEffect[0].GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumeEffects");
            audioEffect[1].GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumeEffects");
        }
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

    public void ActivateSettings()
    {
        menu.SetActive(false);
        canvasSettigs.SetActive(true);
    }

    public void ActivateCredits()
    {
        menu.SetActive(false);
        canvasCredits.SetActive(true);
    }

    public void ExitCredits()
    {
        menu.SetActive(true);
        canvasCredits.SetActive(false);
    }

    public void ExitSettings()
    {
        menu.SetActive(true);
        canvasSettigs.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
