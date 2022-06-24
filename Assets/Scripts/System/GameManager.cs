using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    public GameObject g_balcony;
    public GameObject g_fader;
    public GameObject controlPanel;
    public GameObject locomotionSystem;
    public GameObject XRRig;
    public GameObject rightHandController;
    public GameObject leftHandController;

    private XRRayInteractor rightHandXRRayInteractor;
    private XRRayInteractor leftHandXRRayInteractor;

    public Fader fader;
    public Balcony balcony;

    public Button activCabinButtons;

    public bool waiting = false;
    public bool safeMode = true;
    public bool isInputEnabled = true;

    public bool isReady = true;
    public float timeToWait;

    private float time = 0;


    private void Awake()
    {
        fader = g_fader.GetComponent<Fader>();
        balcony = g_balcony.GetComponent<Balcony>();
        rightHandXRRayInteractor = rightHandController.GetComponent<XRRayInteractor>();
        leftHandXRRayInteractor = leftHandController.GetComponent<XRRayInteractor>();

        StartCoroutine(DelayCabinAnimation());
    }

    public IEnumerator ChangeFloorFromKeyboard(float waitingTime, int floorNumber)
    {
        isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);

        balcony.GetComponent<Balcony>().SelectFloor(floorNumber);

        fader.FadeOut();
        yield return new WaitForSeconds(waitingTime + waitingTime / 2);

        isInputEnabled = true;
    }

    public IEnumerator ChangeFenceFromKeyboard(float waitingTime, int fenceType)
    {
        isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);

        switch (fenceType)
        {
            case 0:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().ShowFenceFull();
                    break;
                }
            case 1:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().ShowFenceLight();
                    break;
                }
            case 2:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().HideFence();
                    break;
                }
            default:
                {
                    break;
                }
        }

        fader.FadeOut();
        yield return new WaitForSeconds(waitingTime + waitingTime / 2);

        isInputEnabled = true;
    }

    public IEnumerator ActivePlankFromKeyboard(float waitingTime)
    {
        isInputEnabled = false;

        balcony.GetComponent<Balcony>().plank.GetComponent<Plank>().PlankAction();

        yield return new WaitForSeconds(waitingTime);

        isInputEnabled = true;
    }

    public void SafeModeActivation()
    {
        if (safeMode)
        {
            safeMode = false;
            locomotionSystem.gameObject.SetActive(true);
            controlPanel.SetActive(true);
            rightHandXRRayInteractor.enabled = true;
            leftHandXRRayInteractor.enabled = true;
            Debug.Log("Disable safe mode");
        }
        else
        {
            safeMode = true;
            locomotionSystem.gameObject.SetActive(false);
            controlPanel.SetActive(false);
            rightHandXRRayInteractor.enabled = false;
            leftHandXRRayInteractor.enabled = false;
            Debug.Log("Enable safe mode");
        }
    }

    public void SafeZoneActivation()
    {
        isReady = false;
        time = 0;
        timeToWait = 3;

        if (fader.newColor2.a == 1)
        {
            fader.FadeOut();
        }
        if (fader.newColor2.a == 0)
        {
            fader.FadeIn();
        }
    }

    public IEnumerator TeleportPlayerOnAnchor(PlayerAnchor playerAnchor, float waitingTime)
    {
        isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);
        XRRig.transform.position = playerAnchor.transform.position;
        fader.FadeOut();
        isInputEnabled = true;
    }

    private IEnumerator DelayCabinAnimation()
    {
        yield return new WaitForSeconds(1);
        balcony.cabin.ActivateAnimator();
    }

    // Allow to enable/disable OnValueChange function, so we can edit toggles of control pannel without trigger the function
    /////////////////

    public void Mute(UnityEngine.Events.UnityEventBase ev)
    {
        int count = ev.GetPersistentEventCount();
        for (int i = 0; i < count; i++)
        {
            ev.SetPersistentListenerState(i, UnityEngine.Events.UnityEventCallState.Off);
        }
    }

    public void Unmute(UnityEngine.Events.UnityEventBase ev)
    {
        int count = ev.GetPersistentEventCount();
        for (int i = 0; i < count; i++)
        {
            ev.SetPersistentListenerState(i, UnityEngine.Events.UnityEventCallState.RuntimeOnly);
        }
    }

    /////////////////


    private void Update()
    {
        if (!isReady)
        {
            time += Time.deltaTime;
            if(time > 3)
            {
                isReady = true;
            }
        }
    }
}
