using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    [SerializeField]
    private float scaleValue = 5f;
    private List<GameObject> enemiesInsideAttackZone;
    public bool isTargetInside { get; private set; }
    public float ScaleValue
    {
        get { return scaleValue; }
        set { scaleValue = value; }
    }

    private void Awake()
    {
        SetScale();
        enemiesInsideAttackZone = new List<GameObject>();
    }

    private void Update()
    {
       if(enemiesInsideAttackZone.Count == 0)
       {
            isTargetInside = false;
       }
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

    public List<GameObject> GetEnemiesInside()
    {
        return enemiesInsideAttackZone;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isTargetInside = true;
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
