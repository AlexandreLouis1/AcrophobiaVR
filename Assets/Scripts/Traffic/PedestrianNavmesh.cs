using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianNavmesh : MonoBehaviour
{
    Animator animator;
    NavMeshAgent navMeshAgent;

    public bool reachedDestination;
    public Vector3 destination;
    private float destinationDistance;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Vector3 destinationDirection = navMeshAgent.destination - transform.position;

        destinationDistance = destinationDirection.magnitude;
        destinationDirection.y = 0;

        if (destinationDistance >= navMeshAgent.stoppingDistance)
        {
            reachedDestination = false;
        }
        else
        {
            reachedDestination = true;
        }

        navMeshAgent.SetDestination(destination);
    }

    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}
