using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    [SerializeField]
    private float damangeValue = 10;
    public float Value
    {
        get { return damangeValue; }
        set { damangeValue = value; }
    }
}
