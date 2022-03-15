using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fences : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public GameObject fenceFull;
    public GameObject fenceLight;
    public GameObject fenceRotationPoint;

    private Animator fenceAnim;

    private void Start()
    {
        fenceAnim = fenceRotationPoint.GetComponentInChildren<Animator>();
    }

    public void ShowFenceFull()
    {
        if (gameManager.isPlankActive)
        {
            Debug.LogError("Ramenez d'abord la planche.");
        }
        else
        {
            fenceFull.gameObject.SetActive(true);
            fenceLight.gameObject.SetActive(false);

            gameManager.isFenceFullShowing = true;

            gameManager.StartCoroutine("WaitingTime", 1);
        }
    }

    public void ShowFenceLight()
    {
        fenceLight.gameObject.SetActive(true);
        fenceFull.gameObject.SetActive(false);

        gameManager.isFenceFullShowing = false;

        gameManager.StartCoroutine("WaitingTime", 1);
    }

    public void HideFence()
    {
        fenceLight.gameObject.SetActive(false);
        fenceFull.gameObject.SetActive(false);

        gameManager.isFenceFullShowing = false;

        gameManager.StartCoroutine("WaitingTime", 1);
    }

    public void FenceAction()
    {
        if (gameManager.isFencesOpen)
        {
            fenceAnim.SetBool("isOpen", false);
            gameManager.isFencesOpen = false;
        }
        else
        {
            fenceAnim.SetBool("isOpen", true);
            gameManager.isFencesOpen = true;
        }
    }
}
