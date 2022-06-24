using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnchor : MonoBehaviour
{
    public static List<PlayerAnchor> playerAnchorList = new List<PlayerAnchor>();

    private void OnEnable()
    {
        playerAnchorList.Add(this);
    }
}
