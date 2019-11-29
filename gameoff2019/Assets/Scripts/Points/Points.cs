using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int Value { get; private set; }
    private TowerLevelUp towerLevelUp;

    private void Start()
    {
        towerLevelUp = GetComponent<TowerLevelUp>();
    }

    private void Awake()
    {
        Value = 0;
    }
    public void Change(int amount)
    {
        Value += amount;
        towerLevelUp.CheckLevelUp(Value);

    }
}
