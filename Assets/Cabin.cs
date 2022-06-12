using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabin : MonoBehaviour
{
    [SerializeField] private AudioClip elevatorDoorOpen;
    [SerializeField] private AudioClip elevatorDoorClose;
    private AudioSource elevatorDoorAudio;
    private Animator doorAnim;

    private void Awake()
    {
        elevatorDoorAudio = GetComponentInChildren<AudioSource>();
        doorAnim = GetComponentInChildren<Animator>();

        elevatorDoorAudio.clip = elevatorDoorOpen;
        elevatorDoorAudio.Play();
    }

    public void OpenCabin()
    {
        doorAnim.SetBool("isOpen", false);

        elevatorDoorAudio.clip = elevatorDoorClose;
        elevatorDoorAudio.Play();
    }

    public void CloseCabin()
    {
        doorAnim.SetBool("isOpen", true);

        elevatorDoorAudio.clip = elevatorDoorOpen;
        elevatorDoorAudio.Play();
    }
}
