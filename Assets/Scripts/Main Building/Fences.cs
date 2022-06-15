using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fences : MonoBehaviour
{
    public GameObject fenceFull;
    public GameObject fenceLight;
    public GameObject fenceRotationPoint;
    public GameObject balcony;

    private Animator fenceAnim;

    private void Awake()
    {
        fenceAnim = fenceRotationPoint.GetComponentInChildren<Animator>();
    }

    public void ShowFenceFull()
    {
        if (balcony.GetComponent<Balcony>().plank.GetComponent<Plank>().plankAnim.GetBool("isOpen") == true)
        {
            Debug.LogError("Ramenez d'abord la planche.");
        }
        else
        {
            fenceFull.gameObject.SetActive(true);
            fenceLight.gameObject.SetActive(false);
        }
    }

    public void ShowFenceLight()
    {
        fenceLight.gameObject.SetActive(true);
        fenceFull.gameObject.SetActive(false);
    }

    public void HideFence()
    {
        fenceLight.gameObject.SetActive(false);
        fenceFull.gameObject.SetActive(false);
    }

    public void FenceAction()
    {
        if (fenceAnim.GetBool("isOpen") == true)
        {
            fenceAnim.SetBool("isOpen", false);
        }
        else
        {
            fenceAnim.SetBool("isOpen", true);
        }
    }

    public bool CheckFenceState(int typeOfFence)
    {
        bool check;
        switch (typeOfFence)
        {
            case 0:
                {
                    if (fenceFull.activeSelf)
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        return check;
                    }
                }
            case 1:
                {
                    if (fenceLight.activeSelf)
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        return check;
                    }
                }
            case 2:
                {
                    if (!fenceLight.activeSelf && !fenceFull.activeSelf)
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        return check;
                    }
                }
            default:
                {
                    Debug.LogError("Check fence state fail.");
                    check = false;
                    return check;
                }
        }
    }
}
