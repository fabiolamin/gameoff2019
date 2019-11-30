using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerChange : MonoBehaviour
{
    [SerializeField]
    private GameObject[] towers;
    [SerializeField]
    private int[] price;
    private bool isTowerActived = false;

    public void ActiveTower(int value)
    {
        if (!isTowerActived)
        {
            Player player = FindObjectOfType<Player>();
            int wallet = player.Coins;
            if (wallet >= price[value])
            {
                wallet -= price[value];
                player.Coins = wallet;
                FindObjectOfType<Coins>().UpdateCoins();
                isTowerActived = true;
                towers[value].SetActive(true);
            }
        }
    }
}
