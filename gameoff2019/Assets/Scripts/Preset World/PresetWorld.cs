﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresetWorld : MonoBehaviour
{
    [SerializeField]
    Text textCoins;
    int[] qualifiedStage;
    int coins;
    // Start is called before the first frame update
    void Start()
    {
        qualifiedStage = new int[11] {
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

        coins = PlayerPrefs.GetInt("Coins");
        textCoins.text = coins.ToString();
    }
}
