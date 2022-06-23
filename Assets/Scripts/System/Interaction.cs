using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Interaction : MonoBehaviour
{
    public GameObject handRight;
    public GameObject handLeft;
    float animPosition = 0;
    private float waitingTime = 2f;
    private int fenceType;

    [SerializeField] InputActionReference activate;
    [SerializeField] InputActionReference select;
    [SerializeField] InputActionReference handGrip;
    [SerializeField] InputActionReference triggerRightPressed;
    [SerializeField] InputActionReference triggerLeftPressed;

    [SerializeField] XRRayInteractor _RayInteractor;
    [SerializeField] Canvas menu;
    [SerializeField] GameObject balcony;
    [SerializeField] GameManager gameManager;


    void Awake()
    {
        activate.action.performed += ButtonAction;
        select.action.performed += ButtonMenu;
        handGrip.action.performed += SafeZoneActivation;
        triggerRightPressed.action.started += pointingActivation;
        triggerRightPressed.action.canceled += pointingDesactivation;
        triggerLeftPressed.action.started += pointingActivation;
        triggerLeftPressed.action.canceled += pointingDesactivation;
        gameManager = gameManager.GetComponent<GameManager>();
    }

         ////////////////////// CONTROLLER INPUTS //////////////////////////

    private void SafeZoneActivation(InputAction.CallbackContext obj)
    {
        if (gameManager.fader.GetComponent<Fader>().newColor2.a == 1)
        {
            gameManager.fader.GetComponent<Fader>().FadeOut();
        }
        if (gameManager.fader.GetComponent<Fader>().newColor2.a == 0)
        {
            gameManager.fader.GetComponent<Fader>().FadeIn();
        }
    }

    private void pointingActivation(InputAction.CallbackContext obj)
    {
        Debug.Log("trigger ON -- start anim");
        if(obj.action.name == "PointingRight")
        {
            handRight.GetComponent<Animator>().SetBool("isPointing", true);
        }
        else if(obj.action.name == "PointingLeft")
        {
            handLeft.GetComponent<Animator>().SetBool("isPointing", true);
        }

        /*AnimatorStateInfo animationState = hand.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);


        Debug.Log(animationState);
        Debug.Log(animationState.ToString());

        animPosition = 0;
        if (animationState.IsName("Hand_Default"))
        {
            animPosition = 1 - animationState.normalizedTime;
            /*if (animPosition < 0)
                animPosition = 0;
            else
                animPosition = 0;
            
        }*/
        //hand.GetComponent<Animator>().Play("Hand_Pointing", 0, animPosition);
        
    }
    private void pointingDesactivation(InputAction.CallbackContext obj)
    {
        Debug.Log("trigger OFF -- cancel anim");
        Debug.Log(obj.action.name);

        /*AnimatorStateInfo animationState = hand.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        Debug.Log(animationState);
        Debug.Log(animationState.ToString());
        if (animationState.IsName("Hand_Pointing"))
        {
            animPosition = 1 - animationState.normalizedTime;
            /*if (animPosition < 0)
                animPosition = 0;
            else
                animPosition = 0;
            //hand.GetComponent<Animator>().Play("Hand_Default", 0, animPosition);
            
        }*/
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
            }
        } 
    }
}










