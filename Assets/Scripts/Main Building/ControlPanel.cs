using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject plankToggleGo;
    public GameObject emptyFenceToggleGo;
    public GameObject lightFenceToggleGo;
    public GameObject fullFenceToggleGo;

    private Toggle[] toggleList;

    private Toggle plankToggle;
    private Toggle emptyFenceToggle;
    private Toggle lightFenceToggle;
    private Toggle fullFenceToggle;

    private Balcony balcony;

    private void Awake()
    {
        toggleList = FindObjectsOfType<Toggle>();

        plankToggle = plankToggleGo.GetComponent<Toggle>();
        emptyFenceToggle = emptyFenceToggleGo.GetComponent<Toggle>();
        lightFenceToggle = lightFenceToggleGo.GetComponent<Toggle>();
        fullFenceToggle = fullFenceToggleGo.GetComponent<Toggle>();

        gameManager = GameManager.Instance;
    }

    private void Start()
    {
        balcony = GameManager.Instance.balcony;
    }

    private void OnEnable()
    {
        if (GameManager.Instance)
        {
            GameManager.Instance.Mute(plankToggle.onValueChanged);
            GameManager.Instance.Mute(emptyFenceToggle.onValueChanged);
            GameManager.Instance.Mute(lightFenceToggle.onValueChanged);
            GameManager.Instance.Mute(fullFenceToggle.onValueChanged);

            if (balcony.plank.plankAnim.GetBool("isOpen") == true)
            {
                plankToggle.isOn = true;
            }
            else
            {
                plankToggle.isOn = false;
            }

            if (balcony.fences.fenceFull.activeSelf)
            {
                fullFenceToggle.isOn = true;
                lightFenceToggle.isOn = false;
                emptyFenceToggle.isOn = false;
            }

            else if (balcony.fences.fenceLight.activeSelf)
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

            GameManager.Instance.Unmute(plankToggle.onValueChanged);
            GameManager.Instance.Unmute(emptyFenceToggle.onValueChanged);
            GameManager.Instance.Unmute(lightFenceToggle.onValueChanged);
            GameManager.Instance.Unmute(fullFenceToggle.onValueChanged);
        }

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
