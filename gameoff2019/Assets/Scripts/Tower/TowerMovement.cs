using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    // The script is not ready yet.
    [SerializeField]
    private float rotationSpeed = 5f;
    private GameObject targetToLookAt;
    private AttackZone attackZone;

    public float SpeedRotation
    {
        get { return rotationSpeed; }
        set { rotationSpeed = value; }
    }

    private void Update()
    {
        targetToLookAt = GameObject.FindGameObjectWithTag("Enemy");

        if (targetToLookAt != null)
        {
            if (attackZone.isTargetInside)
            {
                LookAtTarget();
            }
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
