using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    [SerializeField] GameObject balcony;

    public Animator plankAnim;
    private AudioSource audioSource;

    private void Awake()
    {
        plankAnim = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlankAction()
    {
        if (balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().fenceFull.activeSelf)
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

            balcony.GetComponent<Balcony>().fences.GetComponent<Fences>().FenceAction();
        }
    }  

    public void ChangeSize(float newSize)
    {
        balcony.GetComponent<Plank>().gameObject.transform.localScale = new Vector3(newSize, balcony.GetComponent<Plank>().gameObject.transform.localScale.y, balcony.GetComponent<Plank>().gameObject.transform.localScale.z);
    }
}
