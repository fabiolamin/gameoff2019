using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasGameOver : MonoBehaviour
{
    [SerializeField]
    GameObject loading;
    public void RestartStage()
    {
        loading.SetActive(true);
        Invoke("Reload", 3);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
