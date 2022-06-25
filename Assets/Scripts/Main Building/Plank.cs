using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public Animator plankAnim;

    private AudioSource audioSource;
    private Fences fences;

    private void Awake()
    {
        plankAnim = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Start()
    {
        fences = GameManager.Instance.balcony.fences;
    }

    public void PlankAction()
    {
        if (fences.fenceFull.activeSelf)
        {
            Debug.LogError("Changez de type de balcon pour pouvoir utiliser la planche");
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

            fences.FenceAction();
        }
    }  

    public void ChangeSize(float newSize)
    {
        transform.localScale = new Vector3(newSize, transform.localScale.y, transform.localScale.z);
    }

    public IEnumerator ActivePlankFromKeyboard(float waitingTime)
    {
        GameManager.Instance.isInputEnabled = false;

        PlankAction();

        yield return new WaitForSeconds(waitingTime);

        GameManager.Instance.isInputEnabled = true;
    }
}
