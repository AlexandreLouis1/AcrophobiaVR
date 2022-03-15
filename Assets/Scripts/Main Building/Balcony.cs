using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony : MonoBehaviour
{
    public GameObject balcony;
    public GameObject cabin;
    public GameObject anchorList;

    public void Awake()
    {
        cabin = GameObject.Find("Cabin");
    }

    public void SelectFloor(int numOfFloor)
    {
        switch (numOfFloor)
        {
            case 0:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(1).position;
                cabin.transform.position = anchorList.GetComponentInChildren<Transform>().Find("AnchorCabinToBalcony").position;
                break;

            case 1:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(1).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 2:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(2).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 3:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(3).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 4:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(4).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 5:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(5).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 6:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 7:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 8:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            case 9:
                balcony.transform.position = anchorList.GetComponentInChildren<Transform>().GetChild(6).position;
                cabin.transform.position = balcony.GetComponentInChildren<Transform>().Find("CabinAnchor").position;
                break;

            default:
                break;
        }
    }
}