using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    [SerializeField]
    private float scaleValue = 5f;
    public List<GameObject> EnemiesInsideAttackZone { get; private set; }
    public bool isTargetInside { get; private set; }
    public float ScaleValue
    {
        get { return scaleValue; }
        set { scaleValue = value; }
    }

    private void Awake()
    {
        SetScale();
        EnemiesInsideAttackZone = new List<GameObject>();
    }

    private void Update()
    {
        isTargetInside = EnemiesInsideAttackZone.Count > 0 ? true : false;
    }

    private void SetScale()
    {
        transform.localScale = Vector3.one * scaleValue;
    }

    public void AddToAttackZone(GameObject enemy)
    {
        EnemiesInsideAttackZone.Add(enemy);
    }

    public void RemoveFromAttackZone(GameObject enemy)
    {
        EnemiesInsideAttackZone.Remove(enemy);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemy = other.gameObject;
            enemy.GetComponent<EnemyCollider>().AttackZone = gameObject.GetComponent<AttackZone>();
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
