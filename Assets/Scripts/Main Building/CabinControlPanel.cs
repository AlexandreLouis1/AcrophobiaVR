using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinControlPanel : MonoBehaviour
{
    [SerializeField] GameObject cabinControlPanel;
    [SerializeField] GameObject gameManager;

    Transform lastButtonActivated;

    private void Start()
    {
        lastButtonActivated = cabinControlPanel.transform.GetChild(0);
        lastButtonActivated.GetComponentInChildren<Animator>().SetBool("isOn", true);
    }

    public void ButtonActivation(Transform button)
    {
        lastButtonActivated.GetComponentInChildren<Animator>().SetBool("isOn", false);
        button.GetComponent<Animator>().SetBool("isOn", true);
        lastButtonActivated = button;
        gameManager.GetComponent<GameManager>().ChangeFloor(button.parent.GetSiblingIndex());
    }
}
