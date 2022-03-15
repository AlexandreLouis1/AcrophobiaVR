using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void isOn()
    {
        GetComponent<Animator>().SetBool("isOn", true);
    }

    public void isOff()
    {
        GetComponent<Animator>().SetBool("isOn", false);
    }
}
