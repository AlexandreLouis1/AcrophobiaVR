using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public GameObject plankToggle;
    public GameObject emptyFenceToggle;
    public GameObject lightFenceToggle;
    public GameObject fullFenceToggle;

    private Toggle[] toggleList;

    void Awake()
    {
        toggleList = FindObjectsOfType<Toggle>();
    }

    private void OnEnable()
    {
        gameManager.Mute(plankToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Mute(emptyFenceToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Mute(lightFenceToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Mute(fullFenceToggle.GetComponent<Toggle>().onValueChanged);

        if (GetComponentInParent<Balcony>().plank.GetComponent<Plank>().plankAnim.GetBool("isOpen") == true)
        {
            plankToggle.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            plankToggle.GetComponent<Toggle>().isOn = false;
        }

        if (GetComponentInParent<Balcony>().fences.GetComponent<Fences>().fenceFull.activeSelf)
        {
            fullFenceToggle.GetComponent<Toggle>().isOn = true;
            lightFenceToggle.GetComponent<Toggle>().isOn = false;
            emptyFenceToggle.GetComponent<Toggle>().isOn = false;
        }

        else if (GetComponentInParent<Balcony>().fences.GetComponent<Fences>().fenceLight.activeSelf)
        {
            fullFenceToggle.GetComponent<Toggle>().isOn = false;
            lightFenceToggle.GetComponent<Toggle>().isOn = true;
            emptyFenceToggle.GetComponent<Toggle>().isOn = false;
        }

        else
        {
            fullFenceToggle.GetComponent<Toggle>().isOn = false;
            lightFenceToggle.GetComponent<Toggle>().isOn = false;
            emptyFenceToggle.GetComponent<Toggle>().isOn = true;
        }

        gameManager.Unmute(plankToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Unmute(emptyFenceToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Unmute(lightFenceToggle.GetComponent<Toggle>().onValueChanged);
        gameManager.Unmute(fullFenceToggle.GetComponent<Toggle>().onValueChanged);
    }

    private void Update()
    {
        if (plankToggle.GetComponent<Toggle>().isOn)
        {
            emptyFenceToggle.GetComponent<Toggle>().interactable = false;
            lightFenceToggle.GetComponent<Toggle>().interactable = false;
            fullFenceToggle.GetComponent<Toggle>().interactable = false;
        }
        else
        {
            emptyFenceToggle.GetComponent<Toggle>().interactable = true;
            lightFenceToggle.GetComponent<Toggle>().interactable = true;
            fullFenceToggle.GetComponent<Toggle>().interactable = true;
        }

        if (fullFenceToggle.GetComponent<Toggle>().isOn)
        {
            plankToggle.GetComponent<Toggle>().interactable = false;
        }
        else
        {
            plankToggle.GetComponent<Toggle>().interactable = true;
        }
    }

    public IEnumerator ToggleInteractionWaitingTime(int timeToWait)
    {
        foreach (Toggle toggle in toggleList)
        {
            toggle.interactable = false;
        }

        yield return new WaitForSeconds(timeToWait);

        foreach (Toggle toggle in toggleList)
        {
            toggle.interactable = true;
        }
    }
}
