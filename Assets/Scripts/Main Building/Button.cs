using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public static List<Button> cabinButtonsList = new List<Button>();
    public GameObject g_gameManager;
    public GameObject lightBtn;
    public Material lightOn;
    public Material lightOff;

    private GameManager gameManager;
    private Animator animator;

    private int frameCounter = 0;
    private bool isTouched = false;


    void Awake()
    {
        gameManager = g_gameManager.GetComponent<GameManager>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!isTouched || !gameManager.balcony.isReady) return;
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
        Debug.Log(this.name);
    }


    private void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.name == "LeftHandColider" || other.gameObject.name == "RightHandColider") && isTouched == true)
        {
            isTouched = false;
            frameCounter = 0;
            if (gameManager.activCabinButtons != this)
            {
                lightBtn.GetComponent<Renderer>().material = lightOff;
            }
        }
    }

    public void isOn()
    {
        if(gameManager.activCabinButtons != null)
        {
            gameManager.activCabinButtons.GetComponent<Button>().isOff();
        }
        StartCoroutine(gameManager.balcony.ChangeFloorCoroutine(int.Parse(this.name)));
        animator.SetBool("isOn", true);
        gameManager.activCabinButtons = this;
    }

    public void isOff()
    {
        animator.SetBool("isOn", false);
        lightBtn.GetComponent<Renderer>().material = lightOff;
    }
}
