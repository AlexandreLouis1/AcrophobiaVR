using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Interaction : MonoBehaviour
{
    [SerializeField] private InputActionReference activate;
    [SerializeField] private InputActionReference select;
    [SerializeField] private XRRayInteractor _RayInteractor;
    [SerializeField] Canvas menu;

    void Start()
    {
        activate.action.performed += ButtonAction;
        select.action.performed += ButtonMenu;
    }

    private void ButtonAction(InputAction.CallbackContext obj)
    {
        if (_RayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit ray))
        {
            if (ray.transform.name == "Button")
            {
                if (ray.transform.GetComponent<Animator>().GetBool("isOn") == false)
                {
                    ray.transform.GetComponentInParent<CabinControlPanel>().ButtonActivation(ray.transform);
                }
            }
        }
    }

    private void ButtonMenu(InputAction.CallbackContext obj)
    {
        if (menu.gameObject.activeSelf)
        {
            menu.gameObject.SetActive(false);
        }
        else
        {
            menu.gameObject.SetActive(true);
        }
        
    }
}
    
