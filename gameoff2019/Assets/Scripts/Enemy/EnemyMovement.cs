using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 3f;
    private NavMeshAgent enemyNavMeshAgent;
    [SerializeField]
    Transform target;
    public float Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    private void Awake()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
        enemyNavMeshAgent.speed = speed;
    }

    private void Update()
    {
        if (gameObject.activeSelf)
        {
            Move();
        }
    }

    void Move()
    {
        enemyNavMeshAgent.destination = target.position;
    }
}
