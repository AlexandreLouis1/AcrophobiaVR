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

    public bool isFenceFullShowing = true;
    public bool isFencesOpen = false;

    private void Awake()
    {
        fenceAnim = fenceRotationPoint.GetComponentInChildren<Animator>();
    }

    public void ShowFenceFull()
    {
        if (gameManager.balcony.GetComponent<Plank>().isPlankActive)
        {
            Debug.LogError("Ramenez d'abord la planche.");
        }
        else
        {
            fenceFull.gameObject.SetActive(true);
            fenceLight.gameObject.SetActive(false);

            isFenceFullShowing = true;

            gameManager.StartCoroutine("ToggleInteractionWaintingTime", 1);
        }
    }

    public void ShowFenceLight()
    {
        fenceLight.gameObject.SetActive(true);
        fenceFull.gameObject.SetActive(false);

        isFenceFullShowing = false;

        gameManager.StartCoroutine("ToggleInteractionWaintingTime", 1);
    }

    public void HideFence()
    {
        fenceLight.gameObject.SetActive(false);
        fenceFull.gameObject.SetActive(false);

        isFenceFullShowing = false;

        gameManager.StartCoroutine("ToggleInteractionWaintingTime", 1);
    }

    public void FenceAction()
    {
        if (isFencesOpen)
        {
            fenceAnim.SetBool("isOpen", false);
            isFencesOpen = false;
        }
        else
        {
            fenceAnim.SetBool("isOpen", true);
            isFencesOpen = true;
        }
    }
}
