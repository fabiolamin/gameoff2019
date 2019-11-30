using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChangingTowers : MonoBehaviour
{
    private TowerChange changeTowersBaseSelected;

    public void SetChangeTowers(TowerChange towerChange)
    {
        changeTowersBaseSelected = towerChange;
    }

    public void ActiveTower(int value)
    {
        changeTowersBaseSelected.ActiveTower(value);
    }
}
