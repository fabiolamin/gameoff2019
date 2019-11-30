using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private Player player;
    private Coins coins;
    private void Awake()
    {
        player = GetComponent<Player>();
    }
    public void AddCoinsPlayer(int bonusCoin)
    {
        player.Coins += bonusCoin;
        coins = FindObjectOfType<Coins>();
        coins.UpdateCoins();
    }
}
