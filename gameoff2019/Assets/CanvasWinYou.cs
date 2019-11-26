using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasWinYou : MonoBehaviour
{
    [SerializeField]
    GameObject canvasTransition;

    public void ReturnMenu()
    {
        canvasTransition.SetActive(true);
        Invoke("GoWorld", 3f);
    }

    public void GoWorld()
    {
        SceneManager.LoadScene(1);
    }
}
