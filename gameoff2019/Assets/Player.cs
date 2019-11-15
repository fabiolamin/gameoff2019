using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int coins = 500;
    [SerializeField]
    private int life = 10;

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
}
