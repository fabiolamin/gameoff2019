using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowers : MonoBehaviour
{
    [SerializeField]
    private GameObject[] towers;
    [SerializeField]
    private int[] price;

    public void ActiveTower(int value)
    {
        Player player = FindObjectOfType<Player>();
        int wallet = player.Coins;
        if (wallet >= price[value])
        {
            wallet -= price[value];
            player.Coins = wallet;
            towers[value].SetActive(true);
        }
        else
        {
            Debug.Log("Insufficient Coins");
        }
        
        
    }
}
