using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Interaction : MonoBehaviour
{
    public GameObject handRight;
    public GameObject handLeft;

    [SerializeField] private bool rightGripIsActive = false;
    [SerializeField] private bool leftGripIsActive = false;

    private float waitingTime = 2f;
    private int fenceType;

    [SerializeField] InputActionReference activate;
    [SerializeField] InputActionReference select;
    [SerializeField] InputActionReference triggerRightPressed;
    [SerializeField] InputActionReference triggerLeftPressed;
    [SerializeField] InputActionReference rightHandGrip;
    [SerializeField] InputActionReference leftHandGrip;

    [SerializeField] XRRayInteractor _RayInteractor;
    [SerializeField] Canvas menu;
    [SerializeField] GameObject balcony;
    [SerializeField] GameManager gameManager;


    void Awake()
    {
        activate.action.performed += ButtonAction;
        select.action.performed += ButtonMenu;
        triggerRightPressed.action.started += pointingActivation;
        triggerRightPressed.action.canceled += pointingDesactivation;
        triggerLeftPressed.action.started += pointingActivation;
        triggerLeftPressed.action.canceled += pointingDesactivation;

        rightHandGrip.action.canceled += rightSafeZoneActivationCancel;
        leftHandGrip.action.canceled += leftSafeZoneActivationCancel;
        rightHandGrip.action.performed += rightSafeZoneActivationPerformed;
        leftHandGrip.action.performed += leftSafeZoneActivationPerformed;

        gameManager = gameManager.GetComponent<GameManager>();
    }

    ////////////////////// CONTROLLER INPUTS //////////////////////////

    private void rightSafeZoneActivationCancel(InputAction.CallbackContext obj)
    {
        rightGripIsActive = false;
    }
    private void leftSafeZoneActivationCancel(InputAction.CallbackContext obj)
    {
        leftGripIsActive = false;
    }
    private void rightSafeZoneActivationPerformed(InputAction.CallbackContext obj)
    {
        rightGripIsActive = true;
    }
    private void leftSafeZoneActivationPerformed(InputAction.CallbackContext obj)
    {
        leftGripIsActive = true;
    }

    private void pointingActivation(InputAction.CallbackContext obj)
    {
        if(obj.action.name == "PointingRight")
        {
            handRight.GetComponent<Animator>().SetBool("isPointing", true);
        }
        else if(obj.action.name == "PointingLeft")
        {
            handLeft.GetComponent<Animator>().SetBool("isPointing", true);
        }        
    }
    private void pointingDesactivation(InputAction.CallbackContext obj)
    {
        if (obj.action.name == "PointingRight")
        {
            handRight.GetComponent<Animator>().SetBool("isPointing", false);
        }
        else if (obj.action.name == "PointingLeft")
        {
            handLeft.GetComponent<Animator>().SetBool("isPointing", false);
        }      
    }

    private void ButtonAction(InputAction.CallbackContext obj)
    {
        if (_RayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit ray))
        {
            if (ray.transform.tag == "Button")
            {
                ray.transform.GetComponent<Button>().isOn();
                /*if (ray.transform.GetComponent<Animator>().GetBool("isOn") == false)
                {
                    ray.transform.GetComponentInParent<CabinControlPanel>().ButtonActivation(ray.transform);
                }*/
            }
        }
    }

    private void ButtonMenu(InputAction.CallbackContext obj)
    {
        if (!gameManager.safeMode)
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

    private void Update()
    {
        if (leftGripIsActive && rightGripIsActive && gameManager.isReady)
        {
            gameManager.SafeZoneActivation();
        }

        ////////////////////// KEYBOARD INPUTS //////////////////////////
        ///

        if (gameManager.isInputEnabled)
        {
            // SAFE MODE

            if (Input.GetKeyDown("s"))
            {
                gameManager.SafeModeActivation();
            }

            if (gameManager.safeMode)
            {
                // FLOOR SELECTION
                if (Input.GetKeyDown("0"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 0));
                }
                if (Input.GetKeyDown("1"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 1));
                }
                if (Input.GetKeyDown("2"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 2));
                }
                if (Input.GetKeyDown("3"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 3));
                }
                if (Input.GetKeyDown("4"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 4));
                }
                if (Input.GetKeyDown("5"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 5));
                }
                if (Input.GetKeyDown("6"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 6));
                }
                if (Input.GetKeyDown("7"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 7));
                }
                if (Input.GetKeyDown("8"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 8));
                }
                if (Input.GetKeyDown("9"))
                {
                    StartCoroutine(gameManager.ChangeFloorFromKeyboard(waitingTime, 9));
                }

                // FENCE
                //SHOW FULL FENCE
                if (Input.GetKeyDown("a"))
                {
                    fenceType = 0;
                    if (balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().CheckFenceState(fenceType))
                    {
                        StartCoroutine(gameManager.ChangeFenceFromKeyboard(waitingTime, fenceType));
                    }
                    else
                    {
                        Debug.LogError("Full fence already shown");
                    }
                }

                //SHOW LIGHT FENCE
                if (Input.GetKeyDown("z"))
                {
                    fenceType = 1;
                    if (balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().CheckFenceState(fenceType))
                    {
                        StartCoroutine(gameManager.ChangeFenceFromKeyboard(waitingTime, fenceType));
                    }
                    else
                    {
                        Debug.LogError("Light fence already shown");
                    }
                }

                //HIDE FENCE
                if (Input.GetKeyDown("e"))
                {
                    fenceType = 2;
                    if (balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().CheckFenceState(fenceType))
                    {
                        StartCoroutine(gameManager.ChangeFenceFromKeyboard(waitingTime, fenceType));
                    }
                    else
                    {
                        Debug.LogError("Fence already hidden");
                    }
                }

                // PLANK
                if (Input.GetKeyDown("p"))
                {
                    StartCoroutine(gameManager.ActivePlankFromKeyboard(waitingTime));
                }

                // PLAYER POSITION
                if (Input.GetKeyDown("w") && gameManager.isReady)
                {
                    StartCoroutine(gameManager.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[0], waitingTime));
                }
                if (Input.GetKeyDown("x") && gameManager.isReady)
                {
                    StartCoroutine(gameManager.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[1], waitingTime));
                }
                if (Input.GetKeyDown("c") && gameManager.isReady)
                {
                    StartCoroutine(gameManager.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[2], waitingTime));
                }
                if (Input.GetKeyDown("v") && gameManager.isReady)
                {
                    StartCoroutine(gameManager.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[3], waitingTime));
                }

                // QUIT APPLICATION
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }
        } 
    }
}










