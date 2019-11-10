using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    [SerializeField]
    private float scaleValue = 5f;

    public float ScaleValue
    {
        get { return scaleValue; }
        set { scaleValue = value; }
    }
    public bool isTargetInside { get; private set; }

    private void Start()
    {
        SetScale();
    }

    private void SetScale()
    {
        transform.localScale = Vector3.one * scaleValue;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isTargetInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isTargetInside = false;
        }
    }
}
