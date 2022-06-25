using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony : MonoBehaviour
{
    public GameObject _cabin;
    public GameObject _fences;
    public GameObject _plank;
    public GameObject controlPanel;

    public Cabin cabin;
    public Fences fences;
    public Plank plank;

    private Fader fader;

    public bool isReady = true;

    private void Awake()
    {
        cabin = _cabin.GetComponent<Cabin>();
        fences = _fences.GetComponent<Fences>();
        plank = _plank.GetComponent<Plank>();
    }

    private void Start()
    {
        fader = GameManager.Instance.fader;
    }

    public void SelectFloor(int buttonSelectedIndex)
    {
        foreach (Anchor anchor in Anchor.anchorList)
        {
            if(anchor.floorNumber == buttonSelectedIndex)
            {
                transform.position = anchor.transform.position;
                return;
            }
        }
    }

    public IEnumerator ChangeFloorFromKeyboard(float waitingTime, int floorNumber)
    {
        GameManager.Instance.isInputEnabled = false;

        fader.FadeIn();
        yield return new WaitForSeconds(waitingTime);

        SelectFloor(floorNumber);

        fader.FadeOut();
        yield return new WaitForSeconds(waitingTime + waitingTime / 2);

        GameManager.Instance.isInputEnabled = true;
    }

    public IEnumerator ChangeFloorCoroutine(int buttonSelectedIndex)
    {
        GameManager.Instance.isInputEnabled = false;
        cabin.CloseCabin();

        while(cabin.isOpen)
        {
            yield return null;
        }
        SelectFloor(buttonSelectedIndex);

        cabin.OpenCabin();

        while (!cabin.isOpen)
        {
            yield return null;
        }
        GameManager.Instance.isInputEnabled = true;
    }
}