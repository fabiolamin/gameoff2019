using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private Health enemyHealth;
    private AttackDamage bulletAttackDamage;
    private Pool enemyPool;
    [SerializeField]
    private int bonusCoin;
    public AttackZone TowerAttackZone { get; set; }
    public PlayerCoins playerCoins;

    private void Awake()
    {
        enemyHealth = GetComponent<Health>();
        enemyPool = GameObject.FindGameObjectWithTag("EnemySpawn").GetComponent<Pool>();
        playerCoins = FindObjectOfType<PlayerCoins>();
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
                playerCoins.AddCoinsPlayer(bonusCoin);
                CleanEnemyInTowers();
                TowerAttackZone.towerPoints.Change(10);
                gameObject.SetActive(false);
            }

            bullet.SetActive(false);
        }
    }

    

    private void CleanEnemyInTowers() // clean all towers that have the enemy 
    {
        AttackZone[] attackZones = FindObjectsOfType<AttackZone>();
        foreach (AttackZone at in attackZones)
        {
            at.RemoveFromAttackZone(gameObject);
        }
    }
}
