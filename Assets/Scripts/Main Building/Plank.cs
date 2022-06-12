using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    [SerializeField] GameObject plank;
    [SerializeField] GameObject fences;

    [SerializeField] GameManager gameManager;

    private Animator plankAnim;
    private AudioSource audioSource;

    public bool isPlankActive = false;

    private void Awake()
    {
        plankAnim = plank.gameObject.GetComponent<Animator>();
        audioSource = plank.gameObject.GetComponent<AudioSource>();
    }

    public void PlankAction()
    {
        if (gameManager.balcony.GetComponent<Fences>().isFenceFullShowing)
        {
            Debug.LogError("Activez les barrières.");
        }

        else
        {
            if (plankAnim.GetBool("isOpen") == true)
            {
                audioSource.Play();
                plankAnim.SetBool("isOpen", false);
            }
            else if (plankAnim.GetBool("isOpen") == false)
            {
                audioSource.Play();
                plankAnim.SetBool("isOpen", true);
            }

            fences.GetComponent<Fences>().FenceAction();

            if (isPlankActive)
            {
                isPlankActive = false;
            }
            else
            {
                isPlankActive = true;
            }
            gameManager.StartCoroutine("ToggleInteractionWaintingTime", 2);
        }
    }  

    public void ChangeSize(float newSize)
    {
        plank.gameObject.transform.localScale = new Vector3(newSize, plank.gameObject.transform.localScale.y, plank.gameObject.transform.localScale.z);
    }
}
