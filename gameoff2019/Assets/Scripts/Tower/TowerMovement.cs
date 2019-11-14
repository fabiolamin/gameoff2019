using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    // The script is not ready yet.
    [SerializeField]
    private float rotationSpeed = 5f;
    [SerializeField]
    private AttackZone attackZone;
    private GameObject targetToLookAt;

    public float SpeedRotation
    {
        get { return rotationSpeed; }
        set { rotationSpeed = value; }
    }

    private void Update()
    {
        targetToLookAt = attackZone.GetTarget();

        if (targetToLookAt != null)
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
