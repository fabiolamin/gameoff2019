using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCoins : MonoBehaviour
{
    [SerializeField]
    private Text txtCoins;
    void Start()
    {
        txtCoins.text = PlayerPrefs.GetInt("Coins").ToString();
    }

}
