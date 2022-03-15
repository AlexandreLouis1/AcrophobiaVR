using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationManager : MonoBehaviour
{

    [SerializeField] private InputActionReference activate;
    [SerializeField] private XRRayInteractor _RayInteractor;
    [SerializeField] TeleportationProvider _teleportationProvider;

    void Start()
    {
        _RayInteractor.enabled = false;
        activate.action.performed += TeleportActivate;
        activate.action.canceled += TeleportCanceled;
    }

    private void TeleportCanceled(InputAction.CallbackContext obj)
    {
        if (_RayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit ray) && _RayInteractor.enabled == true)
        {
            TeleportRequest teleportRequest = new TeleportRequest();
            teleportRequest.destinationPosition = ray.point;
            _teleportationProvider.QueueTeleportRequest(teleportRequest);
        }
        _RayInteractor.enabled = false;
    }

    private void TeleportActivate(InputAction.CallbackContext obj)
    {
        _RayInteractor.enabled = true;
    }
}