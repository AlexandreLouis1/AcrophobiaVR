using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalStairs : MonoBehaviour
{
    [SerializeField] GameObject lateralFences;
    [SerializeField] GameObject floorFencesEasy;
    [SerializeField] GameObject floorFencesHard;

    public void ShowLateralFences()
    {
        lateralFences.SetActive(true);
    }

    private void HideLateralFences()
    {
        lateralFences.SetActive(false);
    }

    public IEnumerator LateralFencesAction()
    {
        GameManager.Instance.isInputEnabled = false;

        GameManager.Instance.fader.FadeIn();
        yield return new WaitForSeconds(1.5f);

        if (lateralFences.gameObject.activeSelf)
        {
            HideLateralFences();
        }
        else
        {
            ShowLateralFences();
        }

        GameManager.Instance.fader.FadeOut();
        GameManager.Instance.isInputEnabled = true;
    }

    public bool GetLateralFencesState()
    {
        return(lateralFences.gameObject.activeSelf);
    }

    public IEnumerator ShowFloorFencesEasy()
    {
        GameManager.Instance.isInputEnabled = false;

        GameManager.Instance.fader.FadeIn();
        yield return new WaitForSeconds(1.5f);

        floorFencesEasy.SetActive(true);
        floorFencesHard.SetActive(false);

        GameManager.Instance.fader.FadeOut();
        GameManager.Instance.isInputEnabled = true;
    }
    public IEnumerator ShowFloorFencesHard()
    {
        GameManager.Instance.isInputEnabled = false;

        GameManager.Instance.fader.FadeIn();
        yield return new WaitForSeconds(1.5f);

        floorFencesEasy.SetActive(false);
        floorFencesHard.SetActive(true);

        GameManager.Instance.fader.FadeOut();
        GameManager.Instance.isInputEnabled = true;
    }

    public void ShowFloorFencesEasyWithoutFader()
    {
        floorFencesEasy.SetActive(true);
        floorFencesHard.SetActive(false);
    }
}
