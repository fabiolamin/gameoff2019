using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent enemyNavMeshAgent;
    [SerializeField]
    private float speed = 3f;
    Transform target;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    private void Awake()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
        enemyNavMeshAgent.speed = speed;
    }

    void Move()
    {
        enemyNavMeshAgent.destination = target.position;
    }

    public void SetTarget(Transform transformTarget)
    {
        target = transformTarget;
        Move();
    }
}
