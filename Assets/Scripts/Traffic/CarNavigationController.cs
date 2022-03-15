using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CarNavigationController : MonoBehaviour
{
    Waypoint destinationWaypoint;
    public Vector3 destination;
    public Vector3 lastPosition;
    public float stopWaypointDistance = 1.5f;
    public bool reachedDestination;
    public float rotationSpeed = 120f;
    public float currentSpeed;
    public float brakeDistance = 2;
    public float velocity = 1.5f;
    public float maxMovementSpeed = 10f;
    public float maxMotorTorque = 50f;
    public float maxBreak = 70f;
    public float maxSteerAngle = 45f;
    public WheelCollider wheelFrontLeft;
    public WheelCollider wheelFrontRight;
    public WheelCollider wheelBackLeft;
    public WheelCollider wheelBackRight;

    public bool isBraking = false;
    public Rigidbody rb;

    [Header("Sensors")]
    public float sensorLength;
    public Vector3 frontSensorPosition;
    public float frontSideSensorPosition;
    public float sensorAngle;
    private float timer;

    [Header("Audio")]
    private AudioSource carAudio;
    private float pitch = 1f;
    private float volume = 1f;


    private void Awake()
    {
        sensorAngle = 30f;
        timer = 1f;
        rb = GetComponentInParent<Rigidbody>();
        carAudio = GetComponent<AudioSource>();
        carAudio.volume = volume;
        carAudio.maxDistance = 200;
    }

    private void FixedUpdate()
    {
        destinationWaypoint = GetComponent<WaypointNavigator>().currentWaypoint;
        ApplySteer();
        Sensors();
        AudioManagement();
        if (transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;

            float destinationDistance = destinationDirection.magnitude;

            if(destinationDistance >= stopWaypointDistance)
            {
                reachedDestination = false;
                Drive();
                Braking();
            }
            else
            {
                reachedDestination = true;
            }
        }

    }
    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }

    private void Sensors()
    {
        timer -= Time.deltaTime;
        RaycastHit hit;
        Vector3 sensorStartingPos = transform.position;
        sensorStartingPos += transform.forward * frontSensorPosition.z;
        sensorStartingPos += transform.up * frontSensorPosition.y;

        if(timer <= 0)
        {
            isBraking = false;
            timer = 1f;
        }

        //Front center sensors
        if (Physics.Raycast(sensorStartingPos, transform.forward, out hit, sensorLength))
        {
            if (hit.transform.tag == "Car" || hit.transform.tag == "Crossroad")
            {
                timer += Time.deltaTime;
                isBraking = true;
            }
        }
        Debug.DrawRay(sensorStartingPos, transform.forward * sensorLength, Color.blue);

        //Front right center sensors
        sensorStartingPos += transform.right * frontSideSensorPosition;
        if (Physics.Raycast(sensorStartingPos, transform.forward, out hit, sensorLength))
        {
            if (hit.transform.tag == "Car" || hit.transform.tag == "Crossroad")
            {
                isBraking = true;
            }
        }
        Debug.DrawRay(sensorStartingPos, transform.forward * sensorLength, Color.yellow);

        //Right side sensor
        if (Physics.Raycast(sensorStartingPos, Quaternion.AngleAxis(sensorAngle, transform.up) * transform.forward * sensorLength, out hit, sensorLength))
        {
            if (hit.transform.tag == "Car" || hit.transform.tag == "Crossroad")
            {
                isBraking = true;
            }
        }
        Debug.DrawRay(sensorStartingPos, Quaternion.AngleAxis(sensorAngle, transform.up) * transform.forward * sensorLength, Color.green);
    }

    private void ApplySteer()
    {
        Vector3 pos = destinationWaypoint.transform.position;
        Vector3 relativeVector = transform.InverseTransformPoint(pos);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFrontLeft.steerAngle = newSteer;
        wheelFrontRight.steerAngle = newSteer;
    }

    private void Drive()
    {
        currentSpeed = rb.velocity.magnitude * 3.36f;
        if(currentSpeed < maxMovementSpeed && isBraking == false)
        {
            wheelFrontLeft.motorTorque = maxMotorTorque;
            wheelFrontRight.motorTorque = maxMotorTorque;
            rb.drag = 0;
        }
        else
        {
            wheelFrontLeft.motorTorque = 0;
            wheelFrontRight.motorTorque = 0;
            rb.drag = 50f;
        }
    }

    private void Braking()
    {
        if (isBraking)
        {
            rb.drag = 4f;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void AudioManagement()
    {
        pitch = currentSpeed / 10;
        carAudio.pitch = pitch;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SpeedLimit")
        {
            maxMovementSpeed = 10f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SpeedLimit")
        {
            maxMovementSpeed = 20f;
        }
    }
}
