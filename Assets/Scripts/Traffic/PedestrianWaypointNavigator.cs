using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianWaypointNavigator : MonoBehaviour
{
    PedestrianNavmesh controller;

    public Waypoint currentWaypoint;
    [SerializeField] int direction = 0;
    private Waypoint[] waypointList;
    private Waypoint nearWaypoint;
    private Vector3 diff;
    private float currentDistance;
    private float distance = Mathf.Infinity;

    private void Awake()
    {
        controller = GetComponent<PedestrianNavmesh>();
        currentWaypoint = GetClosestWaypoint();
        controller.SetDestination(currentWaypoint.GetPosition());
    }

    private void Update()
    {
        if (controller.reachedDestination)
        {
            bool shouldBranch = false;

            if (currentWaypoint.branches != null && currentWaypoint.branches.Count > 0)
            {
                shouldBranch = Random.Range(0f, 1f) <= currentWaypoint.branchRatio ? true : false;
            }

            if (shouldBranch)
            {
                currentWaypoint = currentWaypoint.branches[Random.Range(0, currentWaypoint.branches.Count - 1)];
            }
            else
            {
                if (direction == 0)
                {
                    if (currentWaypoint.nextWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                        direction = 1;
                    }
                }
                else if (direction == 1)
                {
                    if (currentWaypoint.previousWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                        direction = 0;
                    }
                }
            }
            controller.SetDestination(currentWaypoint.GetPosition());
        }
    }

    Waypoint GetClosestWaypoint()
    {
        waypointList = FindObjectsOfType(typeof(Waypoint)) as Waypoint[];

        Vector3 position = transform.position;

        foreach (Waypoint Waypoint in waypointList)
        {
            diff = Waypoint.transform.position - position;
            currentDistance = diff.sqrMagnitude;

            if (currentDistance < distance && Waypoint.transform.parent.tag == "Pedestrian")
            {
                nearWaypoint = Waypoint;
                distance = currentDistance;
            }
        }
        return nearWaypoint;
    }

    void ChangeDirection()
    {
        if (currentWaypoint = null)
        {
            if (direction == 0)
            {
                direction = 1;
            }
            else
            {
                direction = 0;
            }
            //GetClosestWaypoint();
        }
    }
}
