﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChips : MonoBehaviour
{
    [SerializeField]
    private GameObject[] goChips;
    [SerializeField]
    private GameObject canvasGameOver;
    private int chips;
    public bool gameOver { get; private set; }

    private void Start()
    {
        gameOver = false;
        chips = goChips.Length;
        canvasGameOver.SetActive(false);
    }

    public void Damage()
    {
        if (chips > 0)
        {
            goChips[chips - 1].SetActive(false);
            chips--;
            if (chips <= 0)
            {
                gameOver = true;
                canvasGameOver.SetActive(true);
            }
        }
        
    }
}
