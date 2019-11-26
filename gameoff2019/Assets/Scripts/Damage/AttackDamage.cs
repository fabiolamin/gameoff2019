using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    [SerializeField]
    private int damangeValue = 10;
    public int Value
    {
        get { return damangeValue; }
        set { damangeValue = value; }
    }

    public void Change(int amount)
    {
        damangeValue += amount;
    }
}
