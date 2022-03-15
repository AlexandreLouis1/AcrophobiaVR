using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianNavigationController : MonoBehaviour
{
    Waypoint destinationWaypoint;
    Animator animator;
    public Vector3 destination;
    public Vector3 lastPosition;
    [SerializeField] float stopDistance = 1.5f;
    [SerializeField] float speedWalk = 0.7f;
    [SerializeField] float rotationSpeed = 2;

    public bool reachedDestination;

    private Vector3 pos;
    public Vector3 relativePos;
    public float targetAngle;

    [Header("Sensors")]
    public float sensorLenght = 1f;
    public float sensorHigh = 1.5f;
    public float sensorSidePos = 0.3f;
    public bool avoiding = false;
    public bool isTurning = false;
    public float orientation = 20;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isWalking", true);
    }
    void LateUpdate()
    {
        destinationWaypoint = GetComponent<PedestrianWaypointNavigator>().currentWaypoint;

        if (transform.position != destination)
        {
            isMoving();
            //Orientation du personnage en fonction de la position du prochain waypoint
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;
            float destinationDistance = destinationDirection.magnitude;

            //Si obstacle, décalage de la trajectoire
            /*if (avoiding)
            {
                transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.AngleAxis(orientation, Vector3.up), speedWalk * Time.deltaTime);
                transform.position += transform.forward * speedWalk * Time.deltaTime;
            }
            */




            if (destinationDistance >= stopDistance)
            {
                reachedDestination = false;
            }
            else
            {
                reachedDestination = true;
            }
        }
    }

    //Si obstacle, récupération de l'angle d'impact afin de modifier la trajectoire
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pedestrian") || other.gameObject.CompareTag("Props"))
        {
            Vector3 targetDir = other.transform.position - transform.position;
            Debug.DrawRay(transform.position, targetDir, Color.red, 5f);

            targetAngle = Vector3.SignedAngle(transform.forward, targetDir, transform.position);
            Debug.Log(gameObject.name + " : " + Vector3.SignedAngle(transform.forward, targetDir, transform.position));
            avoiding = true;
        }
    }
    //Lorsque l'obstacle a bien été esquivé, retour à la normale
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pedestrian") || other.gameObject.CompareTag("Props"))
        {
            avoiding = false;
            speedWalk = 0.7f;
        }
    }

    void isMoving()
    {
        pos = destinationWaypoint.transform.position;
        relativePos = pos - transform.position;

        if (avoiding)
        {
            speedWalk = 0.5f;
            if(targetAngle > 0)
            {
                pos += new Vector3(0, 0, -5);
            }
            else
            {
                pos += new Vector3(0, 0, 5);
            }
            relativePos = pos - transform.position;

            Quaternion rotation = Quaternion.LookRotation(relativePos);
            Quaternion current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, rotationSpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, pos, speedWalk * Time.deltaTime);
        }

        else
        {
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            Quaternion current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, rotationSpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, pos, speedWalk * Time.deltaTime);
        }
    }

    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}
