using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonTower : MonoBehaviour
{
    private ControlChangingTowers controlChangingTowers;
    private ConfigureBaseTowers configureBaseTowers;

    private void Start()
    {
        configureBaseTowers = FindObjectOfType<ConfigureBaseTowers>();
        controlChangingTowers = FindObjectOfType<ControlChangingTowers>();
    }
    public void ClickTower(int tower)
    {
        configureBaseTowers.CloseToolbarBase();
        controlChangingTowers.ActiveTower(tower);
    }
}
