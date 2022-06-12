using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public float fadeDuration = 0.5f;
    public Color fadeColor;
    public Color newColor2;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        FadeOut();
    }

    public void FadeIn()
    {
        Fade(0, 1);
    }
    
    public void FadeOut()
    {
        Fade(1, 0);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }
    
    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        newColor2 = fadeColor;
        newColor2.a = alphaOut;

        rend.material.SetColor("_Color", newColor2);
    }
}