using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitGame : MonoBehaviour
{
    int indexScene;

    private void Start()
    {
        indexScene = SceneManager.GetActiveScene().buildIndex;
    }
    public void Exit()
    {
        SceneManager.LoadScene(indexScene - 1);
    }
}
