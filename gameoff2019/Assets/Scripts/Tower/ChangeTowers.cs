using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowers : MonoBehaviour
{
    [SerializeField]
    private GameObject[] towers;

    public void ActiveTower(int value)
    {
        towers[value].SetActive(true);
    }
}
