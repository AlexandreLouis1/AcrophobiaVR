using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] GameObject controlPanel;

    private GameObject plankToggle;
    private GameObject emptyFenceToggle;
    private GameObject lightFenceToggle;
    private GameObject fullFenceToggle;

    void Start()
    {
        plankToggle = GameObject.Find("Toggle Plank");
        emptyFenceToggle = GameObject.Find("Toggle Empty");
        lightFenceToggle = GameObject.Find("Toggle Light");
        fullFenceToggle = GameObject.Find("Toggle Full");
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
    }
}
