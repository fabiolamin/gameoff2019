using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
            LookAtTarget(attackZone.GetEnemiesInside().FirstOrDefault());
        }
    }

    private void LookAtTarget(GameObject target)
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
        }
    }
}
