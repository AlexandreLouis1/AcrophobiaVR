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
    private Fader fader;

    private void Awake()
    {
        fenceAnim = fenceRotationPoint.GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        fader = GameManager.Instance.fader;
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

    public bool GetFenceAnimState()
    {
        return fenceAnim.GetBool("isOpen");
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

    public IEnumerator ChangeFenceFromKeyboard(float waitingTime, int fenceType)
    {
        GameManager.Instance.isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);

        switch (fenceType)
        {
            case 0:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().ShowFenceFull();
                    break;
                }
            case 1:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().ShowFenceLight();
                    break;
                }
            case 2:
                {
                    balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().HideFence();
                    break;
                }
            default:
                {
                    break;
                }
        }

        fader.FadeOut();
        yield return new WaitForSeconds(waitingTime + waitingTime / 2);

        GameManager.Instance.isInputEnabled = true;
    }
}
