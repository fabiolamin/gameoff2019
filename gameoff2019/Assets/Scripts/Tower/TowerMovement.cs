using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 5f;
    [SerializeField]
    private AttackZone attackZone;

    public float SpeedRotation
    {
        get { return rotationSpeed; }
        private set { rotationSpeed = value; }
    }

    private void Update()
    {
        if (attackZone.isTargetInside)
        {
            foreach(GameObject enemy in attackZone.GetEnemiesInside())
            {
                LookAtTarget(enemy);
            }
        }
    }

    private void LookAtTarget(GameObject target)
    {
        if (target.activeSelf)
        {
            transform.LookAt(target.transform);
        }
    }
}
