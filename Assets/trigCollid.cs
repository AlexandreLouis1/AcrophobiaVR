using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigCollid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enterrrrrrrrrrrrr");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("colide from " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit from " + other.gameObject.name);
    }
}
