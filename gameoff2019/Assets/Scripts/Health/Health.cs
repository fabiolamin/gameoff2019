using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int value = 100;
    public int Value
    {
        get { return value; }
    }

    public void Change(int amount)
    {
        value += amount;
    }
}
