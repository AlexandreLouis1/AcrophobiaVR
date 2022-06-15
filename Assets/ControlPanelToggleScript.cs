using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanelToggleScript : MonoBehaviour
{
    [SerializeField] GameObject controlPanel;
    
    void OnToggleChange(Toggle toggle)
    {
        StartCoroutine(controlPanel.GetComponent<ControlPanel>().ToggleInteractionWaitingTime(3));
    }
}
