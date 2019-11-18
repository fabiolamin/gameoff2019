using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonTower : MonoBehaviour
{
    private ControlChangingTowers controlChangingTowers;
    private ConfigureBaseTowers configureBaseTowers;
    [SerializeField]
    private GameObject[] ButtonsTowerSelected;

    private void Start()
    {
        configureBaseTowers = FindObjectOfType<ConfigureBaseTowers>();
        controlChangingTowers = FindObjectOfType<ControlChangingTowers>();
        PresetButtonsTowers();
    }

    private void PresetButtonsTowers()
    {
        ButtonsTowerSelected[1].SetActive(PlayerPrefs.GetInt("BasicTowerA") != 0);
        ButtonsTowerSelected[2].SetActive(PlayerPrefs.GetInt("BasicTowerB") != 0);
        ButtonsTowerSelected[3].SetActive(PlayerPrefs.GetInt("BasicTowerC") != 0);
        ButtonsTowerSelected[4].SetActive(PlayerPrefs.GetInt("MiddleTowerA") != 0);
        ButtonsTowerSelected[5].SetActive(PlayerPrefs.GetInt("MiddleTowerB") != 0);
        ButtonsTowerSelected[6].SetActive(PlayerPrefs.GetInt("MiddleTowerC") != 0);
        ButtonsTowerSelected[7].SetActive(PlayerPrefs.GetInt("MiddleTowerD") != 0);
        ButtonsTowerSelected[8].SetActive(PlayerPrefs.GetInt("StrongTowerA") != 0);
        ButtonsTowerSelected[9].SetActive(PlayerPrefs.GetInt("StrongTowerB") != 0);
        ButtonsTowerSelected[10].SetActive(PlayerPrefs.GetInt("StrongTowerC") != 0);

    }

    public void ClickTower(int tower)
    {
        configureBaseTowers.CloseToolbarBase();
        controlChangingTowers.ActiveTower(tower);
    }
}
