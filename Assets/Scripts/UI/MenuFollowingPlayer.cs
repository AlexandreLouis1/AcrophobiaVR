using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFollowingPlayer : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    [SerializeField] Camera firstPersonCamera;

    [Range(0, 1)]
    [SerializeField] float smoothFactor = 0.060f;

    [SerializeField] float offsetRadius = 0.3f;
    [SerializeField] float distanceFromCamera = 65;

    void Update()
    {
        menuCanvas.transform.rotation = firstPersonCamera.transform.rotation;
        Vector3 cameraCenter = firstPersonCamera.transform.position + firstPersonCamera.transform.forward * distanceFromCamera;
        Vector3 currentPos = menuCanvas.transform.position;

        Vector3 direction = currentPos - cameraCenter;

        Vector3 targetPosition = cameraCenter + direction.normalized * offsetRadius;

        menuCanvas.transform.position = Vector3.Lerp(currentPos, targetPosition, smoothFactor);
    }

    private void OnEnable()
    {
        menuCanvas.transform.position = firstPersonCamera.transform.position;
    }
}
