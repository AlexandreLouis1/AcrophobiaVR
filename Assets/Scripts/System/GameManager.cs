using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject balcony;
    public GameObject fader;
    public GameObject controlPanel;
    public Button activCabinButtons;
    public GameObject locomotionSystem;

    public bool waiting = false;
    public bool safeMode = true;
    public bool isInputEnabled = true;

    public IEnumerator ChangeFloorFromKeyboard(float waitingTime, int floorNumber)
    {
        isInputEnabled = false;

        fader.GetComponent<Fader>().FadeIn();
        yield return new WaitForSeconds(waitingTime);

        balcony.GetComponent<Balcony>().SelectFloor(floorNumber);

        fader.GetComponent<Fader>().FadeOut();
        yield return new WaitForSeconds(waitingTime + waitingTime / 2);

        isInputEnabled = true;
    }

    public IEnumerator ChangeFenceFromKeyboard(float waitingTime, int fenceType)
    {
        isInputEnabled = false;

        fader.GetComponent<Fader>().FadeIn();
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

        fader.GetComponent<Fader>().FadeOut();
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
            Debug.Log("Disable safe mode");
        }
        else
        {
            safeMode = true;
            locomotionSystem.gameObject.SetActive(false);
            controlPanel.SetActive(false);
            Debug.Log("Enable safe mode");
        }
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
}
