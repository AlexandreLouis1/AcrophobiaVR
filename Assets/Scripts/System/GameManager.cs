using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject balcony;
    public GameObject fader;
    public GameObject controlPanel;

    public Toggle[] toggleList;

    public GameObject locomotionSystem;

    public bool waiting = false;
    public bool safeMode = true;
    public bool isInputEnabled = false;

    private void Start()
    {
        locomotionSystem.SetActive(false);
        toggleList = FindObjectsOfType<Toggle>();

        StartCoroutine("Starting", 3);
    }

    public IEnumerator Starting(int timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);

        isInputEnabled = true;
    }

    private IEnumerator ToggleInteractionWaintingTime(int timeToWait)
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
