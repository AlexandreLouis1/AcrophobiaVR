using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorStairs : MonoBehaviour
{
    public int floorNumber;

    public static List<AnchorStairs> anchorStairsList = new List<AnchorStairs>();

    private void OnEnable()
    {
        anchorStairsList.Add(this);
    }
}