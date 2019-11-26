using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    [SerializeField]
    private int valueForce = 10;
    public int Value
    {
        get { return valueForce; }
        set { valueForce = value; }
    }

    public void Change(int amount)
    {
        valueForce += amount;
    }
}
