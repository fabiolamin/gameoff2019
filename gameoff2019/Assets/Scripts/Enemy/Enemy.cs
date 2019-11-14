using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float id;
    public void SetId(float value)
    {
        id = value;
    }

    public float GetId()
    {
        return id;
    }
}
