using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    [SerializeField]
    private float scaleValue = 5f;
    [SerializeField]
    private List<GameObject> enemysRow;
    private GameObject target;

    public float ScaleValue
    {
        get { return scaleValue; }
        set { scaleValue = value; }
    }
    public bool isTargetInside { get; private set; }

    private void Start()
    {
        InicializeComponents();
        SetScale();
    }

    private void InicializeComponents()
    {
        target = null;
        isTargetInside = false;
        enemysRow = new List<GameObject>();
    }

    private void SetScale()
    {
        transform.localScale = Vector3.one * scaleValue;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isTargetInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            OrganizeQueueEnemies(other.gameObject);
        }
    }

    private void OrganizeQueueEnemies(GameObject enemy)
    {
        float enemyId = enemy.GetComponent<Enemy>().GetId();
        int countEnemy = 0;
        if (enemysRow.Count > 0)
        {
            foreach (GameObject go in enemysRow)
            {
                float enemySearchId = go.GetComponent<Enemy>().GetId();
                if (enemyId == enemySearchId)
                {
                    enemysRow.RemoveAt(countEnemy);
                    break;
                }
                countEnemy++;
            }
            if (enemysRow.Count > 0)
            {
                target = enemysRow[0];
            }
            else
            {
                ResetTarget();
            }
        }
        else
        {
            ResetTarget();
        }
    }

    private void ResetTarget()
    {
        target = null;
        isTargetInside = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (target == null)
            {
                target = other.gameObject;
            }
            enemysRow.Add(other.gameObject);
        }
    }

    public GameObject GetTarget()
    {
        return target;
    }
}
