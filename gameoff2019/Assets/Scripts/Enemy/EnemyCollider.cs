using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private Health enemyHealth;
    private AttackDamage bulletAttackDamage;
    public AttackZone AttackZone { get; set; }

    private void Awake()
    {
        enemyHealth = GetComponent<Health>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            bulletAttackDamage = collision.gameObject.GetComponent<AttackDamage>();
            enemyHealth.Change(-bulletAttackDamage.Value);
            if (enemyHealth.Value <= 0)
            {
                AttackZone.RemoveFromAttackZone(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
