using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinControlPanel : MonoBehaviour
{
    //Transform lastButtonActivated;

    
    



    /*private void Awake()
    {
        lastButtonActivated = transform.GetChild(0);
        lastButtonActivated.GetComponentInChildren<Animator>().SetBool("isOn", true);
    }*/

    /**
    public void ButtonActivation(Transform button)
    {
        lastButtonActivated.GetComponentInChildren<Animator>().SetBool("isOn", false);
        button.GetComponent<Animator>().SetBool("isOn", true);

        lastButtonActivated = button;

        gameObject.GetComponentInParent<Balcony>().ChangeFloor(button.parent.GetSiblingIndex());
    }
    **/
}
