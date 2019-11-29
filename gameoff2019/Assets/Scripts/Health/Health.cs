using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float value = 100;
    public float Value
    {
        get { return value; }
    }

    public void Change(float amount)
    {
        value += amount;
    }
}
