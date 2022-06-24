using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony : MonoBehaviour
{
    public GameObject g_cabin;
    public GameObject fences;
    public GameObject plank;
    public GameObject controlPanel;

    public Cabin cabin;

    public bool isReady = true;

    private void Awake()
    {
        cabin = g_cabin.GetComponent<Cabin>();
    }

    public void SelectFloor(int buttonSelectedIndex)
    {
        foreach (Anchor anchor in Anchor.anchorList)
        {
            if(anchor.floorNumber == buttonSelectedIndex)
            {
                transform.position = anchor.transform.position;
                return;
            }
        }
    }

    public IEnumerator ChangeFloorCoroutine(int buttonSelectedIndex)
    {
        isReady = false;
        cabin.CloseCabin();

        while(cabin.isOpen)
        {
            yield return null;
        }
        Debug.Log("Cabin Open");
        SelectFloor(buttonSelectedIndex);

        cabin.OpenCabin();

        while (!cabin.isOpen)
        {
            yield return null;
        }
        Debug.Log("Cabin close");
        isReady = true;
    }
}