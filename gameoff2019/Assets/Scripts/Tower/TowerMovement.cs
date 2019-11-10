using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    // The script is not ready yet.
    [SerializeField]
    private float rotationSpeed = 5f;
    [SerializeField]
    private float distanceToStartLookAt = 1f;
    private GameObject targetToLookAt;

    public float SpeedRotation
    {
        get { return rotationSpeed; }
        set { rotationSpeed = value; }
    }

    public float DistanceToStartLookAt
    {
        get { return distanceToStartLookAt; }
        set { distanceToStartLookAt = value; }
    }

    private void Update()
    {
        targetToLookAt = GameObject.FindGameObjectWithTag("Enemy");

        if (targetToLookAt != null)
        {
            if (IsTargetGettingClose())
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

    private bool IsTargetGettingClose()
    {
        float distance = Vector3.Distance(transform.position, targetToLookAt.transform.position);
        if (distance <= distanceToStartLookAt)
        {
            return true;
        }

        return false;
    }
}
