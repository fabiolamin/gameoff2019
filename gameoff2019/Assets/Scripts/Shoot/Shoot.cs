using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private int position;
    private GameObject bullet;
    private float timerAux;
    private bool isReadyToShoot;
    private Pool bulletPool;
    [SerializeField]
    private AttackZone attackZone;
    [SerializeField]
    private float speed = 125f;
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
        position = 0;
        isReadyToShoot = false;
    }

    private void Update()
    {
        if (attackZone.isTargetInside)
        {
            shootInterval -= Time.deltaTime;
            if (shootInterval <= 0)
            {
                isReadyToShoot = true;
                shootInterval = timerAux;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isReadyToShoot)
        {
            Initiate();
            isReadyToShoot = false;
        }
    }

    private void Initiate()
    {
        if(position <= bulletPool.InstantiatePrefabs.Length - 1)
        {
            bullet = bulletPool.GetPrefab(position);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            position++;
        }

        else
        {
            bulletPool.RecyclePrefabs();
            position = 0;
        }
    }
}
