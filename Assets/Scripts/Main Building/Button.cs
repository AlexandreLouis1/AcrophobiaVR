using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public static List<Button> cabinButtonsList = new List<Button>();
    public GameObject lightBtn;
    public Material lightOn;
    public Material lightOff;

    private GameManager gameManager;
    private Animator animator;

    private int frameCounter = 0;
    private bool isTouched = false;


    void Awake()
    {
        gameManager = GameManager.Instance;
        animator = GetComponent<Animator>();

        if(this.name == "0")
        {
            animator.SetBool("isOn", true);
            lightBtn.GetComponent<Renderer>().material = lightOn;
        }
    }

    private void Update()
    {
        if (!isTouched || !GameManager.Instance.balcony.isReady) return;
        if (frameCounter < 30) frameCounter += 1;
        else if (frameCounter == 30)
        {
            isOn();
        }
    }

    private void OnEnable()
    {
        cabinButtonsList.Add(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        if( (other.gameObject.name == "LeftHandColider" || other.gameObject.name == "RightHandColider") && isTouched == false)
        {
            isTouched = true;
            lightBtn.GetComponent<Renderer>().material = lightOn;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.name == "LeftHandColider" || other.gameObject.name == "RightHandColider") && isTouched == true)
        {
            isTouched = false;
            frameCounter = 0;
            if (GameManager.Instance.activCabinButtons != this)
            {
                lightBtn.GetComponent<Renderer>().material = lightOff;
            }
        }
    }

    public void isOn()
    {
        if(GameManager.Instance.activCabinButtons != null)
        {
            GameManager.Instance.activCabinButtons.GetComponent<Button>().isOff();
        }
        StartCoroutine(GameManager.Instance.balcony.ChangeFloorCoroutine(int.Parse(this.name)));
        animator.SetBool("isOn", true);
        GameManager.Instance.activCabinButtons = this;
        lightBtn.GetComponent<Renderer>().material = lightOn;
    }

    public void isOff()
    {
        animator.SetBool("isOn", false);
        lightBtn.GetComponent<Renderer>().material = lightOff;
    }
}
