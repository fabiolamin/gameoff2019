﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent enemyNavMeshAgent;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
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

    private void Update()
    {
        Move();
    }

    void Move()
    {
        enemyNavMeshAgent.destination = target.position;
    }
}