using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelection : MonoBehaviour
{
    [SerializeField]
    GameObject gema;
    [SerializeField]
    AudioSource audioEffectSelecting;
    [SerializeField]
    AudioSource audioEffectSelected;
    GameLoad gameLoad;
    void Start()
    {
        if (gema!= null)
        {
            gema.SetActive(false);
        }
        gameLoad = FindObjectOfType<GameLoad>();
    }

    private void OnMouseDown()
    {
        audioEffectSelected.Play();
        switch (gameObject.name)
        {
            case "BtnPlay":
                gameLoad.Play();
                break;
            case "BtnContinue":
                gameLoad.Continue();
                break;
            case "BtnExit":
                gameLoad.Exit();
                break;
            case "BtnSettings":
                gameLoad.ActivateSettings();
                break;
            case "BtnCredits":
                gameLoad.ActivateCredits();
                gema.SetActive(false);
                break;
        }
    }

    private void OnMouseEnter()
    {
        
        if (gema != null)
        {
            audioEffectSelecting.Play();
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
