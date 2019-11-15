using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 5f;
    [SerializeField]
    private AttackZone attackZone;
    private GameObject targetToLookAt;

    public float SpeedRotation
    {
        get { return rotationSpeed; }
        private set { rotationSpeed = value; }
    }

    private void Update()
    {
        targetToLookAt = GameObject.FindGameObjectWithTag("Enemy");

        if (targetToLookAt != null && attackZone.isTargetInside)
        {
            LookAtTarget();
        }
    }

    private void LookAtTarget()
    {
        if (targetToLookAt.activeSelf)
        {
            transform.LookAt(targetToLookAt.transform);
        }

    }
}
