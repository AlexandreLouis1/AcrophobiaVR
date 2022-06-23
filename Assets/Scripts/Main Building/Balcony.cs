using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony : MonoBehaviour
{
    public GameObject cabin;
    public GameObject fences;
    public GameObject plank;
    public GameObject controlPanel;


    public int numOfFloor;

    public void SelectFloor(int numOfFloor)
    {
        foreach (Anchor anchor in Anchor.anchorList)
        {
            if(anchor.floorNumber == numOfFloor)
            {
                Debug.Log(anchor.floorNumber);
                transform.position = anchor.transform.position;
                return;
            }
            Debug.Log("debug");
        }

    }

    private IEnumerator ChangeFloorCoroutine()
    {
        cabin.GetComponent<Cabin>().CloseCabin();

        yield return new WaitForSeconds(3);

        SelectFloor(numOfFloor);

        cabin.GetComponent<Cabin>().OpenCabin();
    }

    public void ChangeFloor(int buttonSelectedIndex)
    {
        numOfFloor = buttonSelectedIndex;
        StartCoroutine(ChangeFloorCoroutine());
    }
}