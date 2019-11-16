using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCoins : MonoBehaviour
{
    [SerializeField]
    private Text txtCoins;
    private Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        txtCoins.text = (player.Coins).ToString();
    }

}
