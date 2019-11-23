﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private Health enemyHealth;
    private AttackDamage bulletAttackDamage;
    private Pool enemyPool;
    public AttackZone TowerAttackZone { get; set; }

    private void Awake()
    {
        enemyHealth = GetComponent<Health>();
        enemyPool = GameObject.FindGameObjectWithTag("EnemySpawn").GetComponent<Pool>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameObject bullet = collision.gameObject;
            bulletAttackDamage = bullet.GetComponent<AttackDamage>();
            enemyHealth.Change(-bulletAttackDamage.Value);
            if (enemyHealth.Value <= 0)
            {
                TowerAttackZone.RemoveFromAttackZone(gameObject);
                TowerAttackZone.towerPoints.Change(10);
                int position = enemyPool.GetPrefabPosition(bullet);
                if(position >= 0)
                {
                    enemyPool.ChangePrefabStatus(position, false);
                }
            }

            bullet.SetActive(false);
        }
    }
}
