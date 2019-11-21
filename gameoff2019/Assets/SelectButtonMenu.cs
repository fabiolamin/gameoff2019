using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButtonMenu : MonoBehaviour
{
    [SerializeField]
    GameObject gema;
    LoadGame loadGame;
    // Start is called before the first frame update
    void Start()
    {
        if(gema!= null)
        {
            gema.SetActive(false);
        }
        loadGame = FindObjectOfType<LoadGame>();
    }

    private void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "BtnPlay":
                loadGame.Play();
                break;
            case "BtnContinue":
                loadGame.Continue();
                break;
            case "BtnExit":
                loadGame.Exit();
                break;
            case "BtnSettings":
                loadGame.Settings();
                break;
            case "BtnCredits":
                loadGame.Credits();
                gema.SetActive(false);
                break;
        }
    }

    private void OnMouseEnter()
    {
        if (gema != null)
        {
            gema.SetActive(true);
        }
        
    }

    private void OnMouseExit()
    {
        if (gema != null)
        {
            gema.SetActive(false);
        }
        
    }
}
