using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Interaction : MonoBehaviour
{
    private bool rightGripIsActive = false;
    private bool leftGripIsActive = false;

    private float waitingTime = 2f;
    private int fenceType;
    private float playerSpeed = 100;

    [SerializeField] InputActionReference activate;
    //[SerializeField] InputActionReference select;
    [SerializeField] InputActionReference triggerRightPressed;
    [SerializeField] InputActionReference triggerLeftPressed;
    [SerializeField] InputActionReference rightHandGrip;
    [SerializeField] InputActionReference leftHandGrip;

    [SerializeField] XRRayInteractor _RayInteractor;
    [SerializeField] Canvas menu;

    Fences fences;
    GameManager gameManager;
    Animator leftHandAnimator;
    Animator rightHandAnimator;


    void Awake()
    {
        activate.action.performed += ButtonAction;
        //select.action.performed += ButtonMenu;
        triggerRightPressed.action.started += pointingActivation;
        triggerRightPressed.action.canceled += pointingDesactivation;
        triggerLeftPressed.action.started += pointingActivation;
        triggerLeftPressed.action.canceled += pointingDesactivation;

        rightHandGrip.action.canceled += rightSafeZoneActivationCancel;
        leftHandGrip.action.canceled += leftSafeZoneActivationCancel;
        rightHandGrip.action.performed += rightSafeZoneActivationPerformed;
        leftHandGrip.action.performed += leftSafeZoneActivationPerformed;
    }

    private void Start()
    {
        fences = GameManager.Instance.balcony.fences;
        leftHandAnimator = GameManager.Instance.leftHandController.GetComponent<HandController>().handModel.GetComponent<Animator>();
        rightHandAnimator = GameManager.Instance.rightHandController.GetComponent<HandController>().handModel.GetComponent<Animator>();
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
            rightHandAnimator.SetBool("isPointing", true);
        }
        else if(obj.action.name == "PointingLeft")
        {
            leftHandAnimator.SetBool("isPointing", true);
        }        
    }
    private void pointingDesactivation(InputAction.CallbackContext obj)
    {
        if (obj.action.name == "PointingRight")
        {
            rightHandAnimator.SetBool("isPointing", false);
        }
        else if (obj.action.name == "PointingLeft")
        {
            leftHandAnimator.SetBool("isPointing", false);
        }      
    }

    private void ButtonAction(InputAction.CallbackContext obj)
    {
        if (_RayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit ray))
        {
            if (ray.transform.tag == "Button")
            {
                ray.transform.GetComponent<Button>().isOn();
            }
        }
    }

    /*
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
    */

    private void Update()
    {
        if (leftGripIsActive && rightGripIsActive && gameManager.isReady)
        {
            GameManager.Instance.SafeModeActivation();
        }

        ////////////////////// KEYBOARD INPUTS //////////////////////////
        ///

        if (GameManager.Instance.isInputEnabled)
        {
            // SAFE MODE

            if (Input.GetKeyDown("s"))
            {
                GameManager.Instance.SafeModeActivation();
            }

            if (GameManager.Instance.safeMode)
            {
                // FLOOR SELECTION
                if (Input.GetKeyDown("0") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 0));
                }
                if (Input.GetKeyDown("1") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 1));
                }
                if (Input.GetKeyDown("2") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 2));
                }
                if (Input.GetKeyDown("3") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 3));
                }
                if (Input.GetKeyDown("4") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 4));
                }
                if (Input.GetKeyDown("5") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 5));
                }
                if (Input.GetKeyDown("6") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 6));
                }
                if (Input.GetKeyDown("7") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 7));
                }
                if (Input.GetKeyDown("8") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 8));
                }
                if (Input.GetKeyDown("9") && GameManager.Instance.isInputEnabled)
                {
                    StartCoroutine(GameManager.Instance.balcony.ChangeFloorFromKeyboard(waitingTime, 9));
                }

                // FENCE
                //SHOW FULL FENCE
                if (Input.GetKeyDown("a"))
                {
                    fenceType = 0;
                    if (fences.CheckFenceState(fenceType))
                    {
                        StartCoroutine(GameManager.Instance.balcony.fences.ChangeFenceFromKeyboard(waitingTime, fenceType));
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
                    if (fences.CheckFenceState(fenceType))
                    {
                        StartCoroutine(GameManager.Instance.balcony.fences.ChangeFenceFromKeyboard(waitingTime, fenceType));
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
                    if (fences.CheckFenceState(fenceType))
                    {
                        StartCoroutine(GameManager.Instance.balcony.fences.ChangeFenceFromKeyboard(waitingTime, fenceType));
                    }
                    else
                    {
                        Debug.LogError("Fence already hidden");
                    }
                }

                // PLANK
                if (Input.GetKeyDown("p"))
                {
                    StartCoroutine(GameManager.Instance.balcony.plank.ActivePlankFromKeyboard(waitingTime));
                }

                // PLAYER POSITION
                if (Input.GetKeyDown("w") && GameManager.Instance.isReady)
                {
                    StartCoroutine(GameManager.Instance.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[0], waitingTime));
                }
                if (Input.GetKeyDown("x") && GameManager.Instance.isReady)
                {
                    StartCoroutine(GameManager.Instance.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[1], waitingTime));
                }
                if (Input.GetKeyDown("c") && GameManager.Instance.isReady)
                {
                    StartCoroutine(GameManager.Instance.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[2], waitingTime));
                }
                if (Input.GetKeyDown("v") && GameManager.Instance.isReady)
                {
                    StartCoroutine(GameManager.Instance.TeleportPlayerOnAnchor(PlayerAnchor.playerAnchorList[3], waitingTime));
                }

                // PLAYER MOVEMENTS
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
                }
                if (Input.GetKeyDown(KeyCode.PageUp))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.up * playerSpeed/10 * Time.deltaTime);
                }
                if (Input.GetKeyDown(KeyCode.PageDown))
                {
                    GameManager.Instance.XRRig.transform.Translate(Vector3.down * playerSpeed/10 * Time.deltaTime);
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










