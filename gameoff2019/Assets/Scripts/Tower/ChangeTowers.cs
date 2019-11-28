using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowers : MonoBehaviour
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
                FindObjectOfType<ChangeCoins>().UpdateCoins();
                isTowerActived = true;
                towers[value].SetActive(true);
            }
            else
            {
                Debug.Log("Insufficient Coins");
            }
        }
        else
        {
            Debug.Log("Tower is already activated");
        }
        
        
    }
}
