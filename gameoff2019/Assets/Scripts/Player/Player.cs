using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int coins;
    [SerializeField]
    private int life;
    [SerializeField]
    private int bonusStage;
    public int Coins
    {
        get { return coins; }
        set { coins = value; }
    }
    public int Life
    {
        get { return life; }
        set { life = value; }
    }

    private void Start()
    {
        Coins = PlayerPrefs.GetInt("Coins")+ bonusStage;
    }
}
