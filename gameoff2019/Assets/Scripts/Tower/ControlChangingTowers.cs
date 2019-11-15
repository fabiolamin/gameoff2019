using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChangingTowers : MonoBehaviour
{
    private ChangeTowers changeTowersBaseSelected;

    public void SetChangeTowers(ChangeTowers gt)
    {
        changeTowersBaseSelected = gt;
    }

    public void ActiveTower(int value)
    {
        changeTowersBaseSelected.ActiveTower(value);
    }
}
