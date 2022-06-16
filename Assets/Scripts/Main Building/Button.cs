using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject lightBtn;
    public GameObject cabinControl;
    public Material lightOn;
    public Material lightOff;

    private int frameCounter = 0;
    private bool isTouched = false;
    private bool isActivate = false;


    private void Update()
    {
        if (!isTouched) return;
        if (frameCounter < 30) frameCounter += 1;
        else if (frameCounter == 30)
        {
            cabinControl.GetComponent<CabinControlPanel>().ButtonActivation(transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name);
        if( (other.gameObject.name == "LeftHand Controller" || other.gameObject.name == "RightHand Controller") && isTouched == false)
        {
            isTouched = true;
            lightBtn.GetComponent<Renderer>().material = lightOn;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.name == "LeftHand Controller" || other.gameObject.name == "RightHand Controller") && isTouched == true)
        {
            isTouched = false;
            frameCounter = 0;
            if (!isActivate)
            {
                lightBtn.GetComponent<Renderer>().material = lightOff;
            }
        }
    }

    public void isOn()
    {
        GetComponent<Animator>().SetBool("isOn", true);
        isActivate = true;
    }

    public void isOff()
    {
        GetComponent<Animator>().SetBool("isOn", false);
        lightBtn.GetComponent<Renderer>().material = lightOff;
        isActivate = false;
    }
}
