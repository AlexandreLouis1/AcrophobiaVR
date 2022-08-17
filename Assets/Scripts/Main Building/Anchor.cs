using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    public int floorNumber;

    public static List<Anchor> anchorList = new List<Anchor>();

    private void OnEnable()
    {
        anchorList.Add(this);
    }
}