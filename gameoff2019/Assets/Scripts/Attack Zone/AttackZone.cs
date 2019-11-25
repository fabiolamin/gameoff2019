using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AttackZone : MonoBehaviour
{
    private List<GameObject> enemiesInsideAttackZone;
    [SerializeField]
    private float scaleValue = 5f;
    public Points towerPoints;
    public bool isTargetInside { get; private set; }
    public float ScaleValue
    {
        get { return scaleValue; }
        set { scaleValue = value; }
    }

    private void Awake()
    {
        //SetScale();
        enemiesInsideAttackZone = new List<GameObject>();
    }

    private void Update()
    {
        isTargetInside = enemiesInsideAttackZone.Count > 0 ? true : false;
    }

    private void SetScale()
    {
        transform.localScale = Vector3.one * scaleValue;
    }

    public void AddToAttackZone(GameObject enemy)
    {
        enemiesInsideAttackZone.Add(enemy);
    }

    public void RemoveFromAttackZone(GameObject enemy)
    {
        enemiesInsideAttackZone.Remove(enemy);
    }

    public GameObject GetFirstOrDefaultFromAttackZone()
    {
        return enemiesInsideAttackZone.FirstOrDefault();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemy = other.gameObject;
            enemy.GetComponent<EnemyCollider>().TowerAttackZone = gameObject.GetComponent<AttackZone>();
            AddToAttackZone(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            RemoveFromAttackZone(other.gameObject);
        }
    }
}
