using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabin : MonoBehaviour
{
    [SerializeField] private AudioClip elevatorDoorOpen;
    [SerializeField] private AudioClip elevatorDoorClose;
    private AudioSource elevatorDoorAudio;
    public Animator doorAnim;

    public bool isOpen;
    private void Awake()
    {
        elevatorDoorAudio = GetComponentInChildren<AudioSource>();
        doorAnim = GetComponentInChildren<Animator>();
    }

    public void DesactivateAnimator()
    {
        doorAnim.enabled = false;
    }
    public void ActivateAnimator()
    {
        doorAnim.enabled = true;
    }

    public void PlayDoorOpenSound()
    {
        elevatorDoorAudio.clip = elevatorDoorOpen;
        elevatorDoorAudio.Play();
    }
    
    public void PlayDoorCloseSound()
    {
        elevatorDoorAudio.clip = elevatorDoorClose;
        elevatorDoorAudio.Play();
    }

    public void OpenCabin()
    {
        doorAnim.SetBool("isOpen", true);
    }

    public void CloseCabin()
    {
        doorAnim.SetBool("isOpen", false);
    }

    private void SetOpen()
    {
        isOpen = true;
    }
    private void SetClose()
    {
        isOpen = false;
    }
}
