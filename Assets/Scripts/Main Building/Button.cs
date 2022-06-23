using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public static List<Button> cabinButtonsList = new List<Button>();
    public GameObject gameManager;
    public GameObject lightBtn;
    public Material lightOn;
    public Material lightOff;

    private int frameCounter = 0;
    private bool isTouched = false;
    private int buttonIndex;


    void Awake()
    {
        if (this.name == "0")
        {
            isOn();
        }
    }

    private void Update()
    {
        if (!isTouched) return;
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
            if (gameManager.GetComponent<GameManager>().activCabinButtons != this)
            {
                lightBtn.GetComponent<Renderer>().material = lightOff;
            }
        }
    }

    public void isOn()
    {
        Debug.Log("trigger isOn()");
        if(gameManager.GetComponent<GameManager>().activCabinButtons != null)
        {
            gameManager.GetComponent<GameManager>().activCabinButtons.GetComponent<Button>().isOff();
        }
        GetComponent<Animator>().SetBool("isOn", true);
        gameManager.GetComponent<GameManager>().activCabinButtons = this;
        gameManager.GetComponent<GameManager>().balcony.GetComponent<Balcony>().ChangeFloor(int.Parse(this.name));
        Debug.Log(gameManager.GetComponent<GameManager>().activCabinButtons);
    }

    public void isOff()
    {
        GetComponent<Animator>().SetBool("isOn", false);
        lightBtn.GetComponent<Renderer>().material = lightOff;
    }
}
