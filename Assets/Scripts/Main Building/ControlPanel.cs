using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public GameObject plankToggleGo;
    public GameObject emptyFenceToggleGo;
    public GameObject lightFenceToggleGo;
    public GameObject fullFenceToggleGo;

    private Toggle[] toggleList;

    private Toggle plankToggle;
    private Toggle emptyFenceToggle;
    private Toggle lightFenceToggle;
    private Toggle fullFenceToggle;

    void Awake()
    {
        toggleList = FindObjectsOfType<Toggle>();

        plankToggle = plankToggleGo.GetComponent<Toggle>();
        emptyFenceToggle = emptyFenceToggleGo.GetComponent<Toggle>();
        lightFenceToggle = lightFenceToggleGo.GetComponent<Toggle>();
        fullFenceToggle = fullFenceToggleGo.GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        gameManager.Mute(plankToggle.onValueChanged);
        gameManager.Mute(emptyFenceToggle.onValueChanged);
        gameManager.Mute(lightFenceToggle.onValueChanged);
        gameManager.Mute(fullFenceToggle.onValueChanged);

        if (GetComponentInParent<Balcony>().plank.GetComponent<Plank>().plankAnim.GetBool("isOpen") == true)
        {
            plankToggle.isOn = true;
        }
        else
        {
            plankToggle.isOn = false;
        }

        if (GetComponentInParent<Balcony>().fences.GetComponent<Fences>().fenceFull.activeSelf)
        {
            fullFenceToggle.isOn = true;
            lightFenceToggle.isOn = false;
            emptyFenceToggle.isOn = false;
        }

        else if (GetComponentInParent<Balcony>().fences.GetComponent<Fences>().fenceLight.activeSelf)
        {
            fullFenceToggle.isOn = false;
            lightFenceToggle.isOn = true;
            emptyFenceToggle.isOn = false;
        }

        else
        {
            fullFenceToggle.isOn = false;
            lightFenceToggle.isOn = false;
            emptyFenceToggle.isOn = true;
        }

        gameManager.Unmute(plankToggle.onValueChanged);
        gameManager.Unmute(emptyFenceToggle.onValueChanged);
        gameManager.Unmute(lightFenceToggle.onValueChanged);
        gameManager.Unmute(fullFenceToggle.onValueChanged);
    }

    private void Update()
    {
        if (plankToggle.isOn)
        {
            emptyFenceToggle.interactable = false;
            lightFenceToggle.interactable = false;
            fullFenceToggle.interactable = false;
        }
        else
        {
            emptyFenceToggle.interactable = true;
            lightFenceToggle.interactable = true;
            fullFenceToggle.interactable = true;
        }

        if (fullFenceToggle.isOn)
        {
            plankToggle.interactable = false;
        }
        else
        {
            plankToggle.interactable = true;
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
