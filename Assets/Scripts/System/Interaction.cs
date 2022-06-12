using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Interaction : MonoBehaviour
{
    private float waitingTime = 2f;

    [SerializeField] private InputActionReference activate;
    [SerializeField] private InputActionReference select;
    [SerializeField] private InputActionReference handGrip;

    [SerializeField] private XRRayInteractor _RayInteractor;
    [SerializeField] Canvas menu;
    [SerializeField] GameObject controlPanel;
    [SerializeField] private GameManager gameManager;


    void Awake()
    {
        activate.action.performed += ButtonAction;
        select.action.performed += ButtonMenu;
        handGrip.action.performed += SafeZoneActivation;

        gameManager = gameManager.GetComponent<GameManager>();
    }

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
        Debug.Log(gameManager.fader.GetComponent<Fader>().newColor2.a);
    }

    private void ButtonAction(InputAction.CallbackContext obj)
    {
        if(!gameManager.safeMode)
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

    private IEnumerator ChangeFloorFromKeyboard(float waitingTime, int floorNumber)
    {
        gameManager.isInputEnabled = false;

        gameManager.fader.GetComponent<Fader>().FadeIn();
        yield return new WaitForSeconds(waitingTime);

        gameManager.balcony.GetComponent<Balcony>().SelectFloor(floorNumber);

        gameManager.fader.GetComponent<Fader>().FadeOut();
        yield return new WaitForSeconds(waitingTime+waitingTime/2);

        gameManager.isInputEnabled = true;
    }

    private void SafeModeActivation()
    {
        if (gameManager.safeMode)
        {
            gameManager.safeMode = false;
            gameManager.locomotionSystem.gameObject.SetActive(true);
            gameManager.controlPanel.SetActive(false);
            Debug.Log("Disable safe mode");
        }
        else
        {
            gameManager.safeMode = true;
            gameManager.locomotionSystem.gameObject.SetActive(false);
            gameManager.controlPanel.SetActive(true);
            Debug.Log("Enable safe mode");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("0") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 0));
        }
        if (Input.GetKeyDown("1") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 1));
        }
        if (Input.GetKeyDown("2") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 2));
        }
        if (Input.GetKeyDown("3") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 3));
        }
        if (Input.GetKeyDown("4") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 4));
        }
        if (Input.GetKeyDown("5") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 5));
        }
        if (Input.GetKeyDown("6") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 6));
        }
        if (Input.GetKeyDown("7") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 7));
        }
        if (Input.GetKeyDown("8") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 8));
        }
        if (Input.GetKeyDown("9") && gameManager.isInputEnabled)
        {
            StartCoroutine(ChangeFloorFromKeyboard(waitingTime, 9));
        }

        if (Input.GetKeyDown("m"))
        {
            if (controlPanel.activeSelf)
            {
                controlPanel.SetActive(false);
            }
            else
            {
                controlPanel.SetActive(true);
            }
        }

        if (Input.GetKeyDown("s"))
        {
            SafeModeActivation();
        }

        if (Input.GetKeyDown("a"))
        {

        }
        if (Input.GetKeyDown("z"))
        {

        }
        if (Input.GetKeyDown("e"))
        {

        }
    }
}
    
