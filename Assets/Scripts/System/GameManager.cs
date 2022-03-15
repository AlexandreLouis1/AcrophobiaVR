using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    public GameObject elevator;
    public GameObject balcony;

    public Toggle[] toggleList;

    private Animator doorAnim;
    
    private Balcony balconyMovement;

    [SerializeField] private AudioClip elevatorDoorOpen;
    [SerializeField] private AudioClip elevatorDoorClose;
    private AudioSource elevatorDoorAudio;

    public bool waiting = false;
    public bool isFenceFullShowing = true;
    public bool isPlankActive = false;
    public bool isFencesOpen = false;

    public int numOfFloor;

    private void Start()
    {
        doorAnim = elevator.gameObject.GetComponent<Animator>();
        elevatorDoorAudio = elevator.gameObject.GetComponentInChildren<AudioSource>();
        balconyMovement = balcony.GetComponent<Balcony>();
        toggleList = FindObjectsOfType<Toggle>();

        StartCoroutine("WaitingTime", 2);
    }

    private IEnumerator WaitingTime(int timeToWait)
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

    private IEnumerator ChangeFloorCoroutine()
    {
        doorAnim.SetBool("isOpen", false);

        elevatorDoorAudio.clip = elevatorDoorClose;
        elevatorDoorAudio.Play();

        yield return new WaitForSeconds(3);

        balconyMovement.SelectFloor(numOfFloor);

        elevatorDoorAudio.clip = elevatorDoorOpen;
        elevatorDoorAudio.Play();

        doorAnim.SetBool("isOpen", true);
    }

    public void ChangeFloor(int buttonSelectedIndex)
    {
        numOfFloor = buttonSelectedIndex;
        StartCoroutine(ChangeFloorCoroutine());
    }
}
