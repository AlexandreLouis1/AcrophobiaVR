using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _balcony;
    [SerializeField] private GameObject _fader;
    [SerializeField] private GameObject _controlPanel;
    public GameObject locomotionSystem;
    public GameObject XRRig;
    public GameObject rightHandController;
    public GameObject leftHandController;

    private XRRayInteractor rightHandXRRayInteractor;
    private XRRayInteractor leftHandXRRayInteractor;

    public Fader fader;
    public Balcony balcony;
    public ControlPanel controlPanel;

    public Button activCabinButtons;

    public bool waiting = false;
    public bool safeMode = true;
    public bool isInputEnabled = true;

    public bool isReady = true;
    public float timeToWait;

    private float time = 0;


    private void Awake()
    {
        Instance = this;

        fader = _fader.GetComponent<Fader>();
        balcony = _balcony.GetComponent<Balcony>();
        controlPanel = _controlPanel.GetComponent<ControlPanel>();

        rightHandXRRayInteractor = rightHandController.GetComponent<XRRayInteractor>();
        leftHandXRRayInteractor = leftHandController.GetComponent<XRRayInteractor>();

        StartCoroutine(DelayCabinAnimation());
    }

    public void SafeModeActivation()
    {
        if (safeMode)
        {
            safeMode = false;
            locomotionSystem.gameObject.SetActive(true);
            controlPanel.gameObject.SetActive(true);
            rightHandXRRayInteractor.enabled = true;
            leftHandXRRayInteractor.enabled = true;
            Debug.Log("Disable safe mode");
        }
        else
        {
            safeMode = true;
            locomotionSystem.gameObject.SetActive(false);
            controlPanel.gameObject.SetActive(false);
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
    public IEnumerator TeleportPlayerOnStairsAnchor(float waitingTime, int floorNumber)
    {
        isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);
        XRRig.transform.position = AnchorStairs.anchorStairsList[floorNumber].transform.position;
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
