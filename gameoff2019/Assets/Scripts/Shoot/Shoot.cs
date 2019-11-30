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
    private float speed = 50f;
    [SerializeField]
    private float shootInterval = 0.5f;
    [SerializeField]
    private int forceShoot = 1;
    [SerializeField]
    private ParticleSystem particle;
    private AudioSource audioSource;
    private TowerLevelUp towerLevelUp;
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

    private void Start()
    {
        towerLevelUp = GetComponentInParent<TowerLevelUp>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("VolumeEffects")/2;
        timerAux = shootInterval;
        bulletPool = GetComponent<Pool>();
        foreach(GameObject prefab in bulletPool.InstantiatePrefabs)
        {
            prefab.GetComponent<AttackDamage>().Value = forceShoot * towerLevelUp.GetFactor();
        }
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
                PlaySoundShot();
                particle.Play();
                isReadyToShoot = true;
                shootInterval = timerAux;
            }
        }
        else
        {
            particle.Stop();
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

    private void PlaySoundShot()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void Initiate()
    {
        if(position <= bulletPool.InstantiatePrefabs.Length - 1)
        {
            bullet = bulletPool.GetPrefab(position);
            bullet.GetComponent<AttackDamage>().Value = forceShoot * towerLevelUp.GetFactor();
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
