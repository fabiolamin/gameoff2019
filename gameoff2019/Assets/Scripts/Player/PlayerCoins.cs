using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    Player player;
    private void Awake()
    {
        player = GetComponent<Player>();
    }
    public void AddCoinsPlayer(int bonusCoin)
    {
        player.Coins += bonusCoin;

        ChangeCoins changeCoins = FindObjectOfType<ChangeCoins>();
        changeCoins.UpdateCoins();
    }
}
