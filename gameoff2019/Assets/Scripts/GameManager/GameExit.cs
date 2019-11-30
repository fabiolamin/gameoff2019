using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameExit : MonoBehaviour
{
    [SerializeField]
    GameObject loading;
    int indexScene;

    private void Start()
    {
        loading.SetActive(false);
        indexScene = SceneManager.GetActiveScene().buildIndex;
    }
    public void Exit()
    {
        loading.SetActive(true);
        Invoke("LoadMenu", 3f);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(indexScene - 1);
    }
}
