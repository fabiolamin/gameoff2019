using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float timerAux;
    [SerializeField]
    private AttackZone attackZone;
    [SerializeField]
    private GameObject bullet;
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
        GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        Rigidbody newBulletRigidbody = newBullet.GetComponent<Rigidbody>();
        newBulletRigidbody.velocity += transform.forward * speed;
        Destroy(newBullet, 3f);
    }
}
