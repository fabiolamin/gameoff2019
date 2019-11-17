using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private GameObject bullet;
    private float timerAux;
    private Pool bulletPool;
    [SerializeField]
    private AttackZone attackZone;
    [SerializeField]
    private float speed = 100f;
    [SerializeField]
    private float shootInterval = 0.5f;
    public float Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    public float ShootInterval
    {
        get { return shootInterval; }
        set { shootInterval = value; }
    }

    private void Awake()
    {
        timerAux = shootInterval;
        bulletPool = GetComponent<Pool>();
    }

    private void FixedUpdate()
    {
        if (attackZone.isTargetInside)
        {
            shootInterval -= Time.deltaTime;
            if (shootInterval <= 0)
            {
                Initiate();
                shootInterval = timerAux;
            }
        }
    }

    private void Initiate()
    {
        bullet = bulletPool.GetPrefabs();
        bullet.GetComponent<Rigidbody>().velocity += transform.forward * speed;
    }
}
