using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony : MonoBehaviour
{
    public GameObject cabin;
    public GameObject anchorList;
    public GameObject fences;
    public GameObject plank;
    public GameObject controlPanel;

    public int numOfFloor;

    public void SelectFloor(int numOfFloor)
    {
        switch (numOfFloor)
        {
            case 0:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(1).position;
                cabin.transform.position = anchorList.GetComponentInChildren<Transform>().Find("AnchorCabinToBalcony").position;
                break;

            case 1:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(1).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 2:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(2).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 3:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(3).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 4:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(4).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 5:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(5).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 6:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 7:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 8:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 9:
                transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            default:
                break;
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