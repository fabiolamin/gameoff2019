﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PresetWorld : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textCoins;
    [SerializeField]
    GameObject[] stages;
    [SerializeField]
    GameObject canvasCongratulations;
    private int[] qualifiedStages;
    private int coins;
    void Start()
    {
        qualifiedStages = new int[11] {
            0,
            PlayerPrefs.GetInt("Stage1"),
            PlayerPrefs.GetInt("Stage2"),
            PlayerPrefs.GetInt("Stage3"),
            PlayerPrefs.GetInt("Stage4"),
            PlayerPrefs.GetInt("Stage5"),
            PlayerPrefs.GetInt("Stage6"),
            PlayerPrefs.GetInt("Stage7"),
            PlayerPrefs.GetInt("Stage8"),
            PlayerPrefs.GetInt("Stage9"),
            PlayerPrefs.GetInt("Stage10")};

        for (int i = 1; i < qualifiedStages.Length; i++)
        {
            bool isActive = qualifiedStages[i] != 0;
            stages[i].SetActive(isActive);
        }
        coins = PlayerPrefs.GetInt("Coins");
        textCoins.text = coins.ToString();
        VerifyEndGame();
    }

    private void VerifyEndGame()
    {
        bool endGame = true;
        foreach(int i in qualifiedStages)
        {
            if (i.Equals(1))
            {
                endGame = false;
                break;
            }
        }

        if (endGame)
        {
            canvasCongratulations.SetActive(true);
        }
    }
}
