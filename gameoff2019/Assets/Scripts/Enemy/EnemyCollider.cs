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
    private WinStage winStage;
    [SerializeField]
    private AudioClip soundExplosion;
    [SerializeField]
    private ParticleSystem damangeParticle;
    [SerializeField]
    private ParticleSystem explosionParticle;
    private AudioSource audioSources;

    private void Awake()
    {
        audioSources = GetComponent<AudioSource>();
        audioSources.volume = PlayerPrefs.GetFloat("VolumeEffects");
        enemyHealth = GetComponent<Health>();
        enemyPool = GameObject.FindGameObjectWithTag("EnemySpawn").GetComponent<Pool>();
        playerCoins = FindObjectOfType<PlayerCoins>();
        winStage = FindObjectOfType<WinStage>();
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
                explosionParticle.transform.SetParent(GameObject.FindGameObjectWithTag("Garbage").transform);
                explosionParticle.Play();
                Destroy(explosionParticle, 4f);
                AudioSource.PlayClipAtPoint(soundExplosion,Camera.main.transform.position, PlayerPrefs.GetFloat("VolumeEffects"));
                playerCoins.AddCoinsPlayer(bonusCoin);
                winStage.CountEnemyDestroyed();
                CleanEnemyInTowers();
                TowerAttackZone.towerPoints.Change(10);
                gameObject.SetActive(false);
            }
            else
            {
                damangeParticle.Play();
                audioSources.Play();
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
